// ******************************************************************************************************************************
// ****
// ****      Copyright (c) 2008-2024 Rafael 'Monoman' Teixeira
// ****
// ******************************************************************************************************************************


using System.Data;
using System.Diagnostics;
using System.Globalization;

namespace TickTack;

public class HistoryFile : DataTable
{
    private const char _separator = '\n';
    private const char _columnSeparator = '|';

    private readonly FileInfo _file;
    private readonly FileInfo _backupFile;

    public HistoryFile(string folderPath) {
        _file = new(Path.Combine(folderPath, "history.txt"));
        _backupFile = new(Path.Combine(folderPath, "history_backup.txt"));
        BeginLoadData();
        Columns.Clear();
        Columns.Add(new DataColumn() { DataType = typeof(string), AllowDBNull = false, ColumnName = "Task" });
        Columns.Add(new DataColumn() { DataType = typeof(int), AllowDBNull = true, ColumnName = "Minutes" });
        LoadLines();
        EndLoadData();
        TableName = nameof(HistoryFile);
        RowDeleted += HistoryFile_RowChanged;
        RowChanged += HistoryFile_RowChanged;
    }
    internal void EditOnNpp() => Process.Start(new ProcessStartInfo() {
        UseShellExecute = false,
        Arguments = $"-multiInst -notabbar -nosession -noPlugin {_file.FullName}",
        FileName = @"d:\opt\Notepad++\notepad++.exe"
    })?.WaitForExit();

    private void LoadLines() {
        Rows.Clear();
        if (_file.Exists)
            foreach (var row in ParseHistoryFile(_file))
                Rows.Add(row.Task, row.Minutes);
    }

    private static (string Task, int Minutes)[] ParseHistoryFile(FileInfo file) {
        using var reader = file.OpenText();
        return [.. ReadLines(reader).Select(ParseLine)
                                    .DistinctBy(l => l.Task)
                                    .OrderBy(l => l.Task)];

        static IEnumerable<string> ReadLines(StreamReader reader) =>
            reader.ReadToEnd().Split(_separator, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

        static (string Task, int Minutes) ParseLine(string line) {
            var parts = line.Split(_columnSeparator, StringSplitOptions.TrimEntries);
            return (parts[0], parts.Length > 1 && int.TryParse(parts[1], CultureInfo.InvariantCulture, out int result) ? result : ContentFile.DefaultPeriodInMinutes);
        }
    }

    private bool _enteredRowChanged = false;
    private void HistoryFile_RowChanged(object sender, DataRowChangeEventArgs e) {
        if (_enteredRowChanged) return;
        _enteredRowChanged= true;
        try {
            if (e.Row.ItemArray.Length < 2 || e.Row.ItemArray[1] is not int)
                e.Row.SetField(e.Row.Table.Columns[1], ContentFile.DefaultPeriodInMinutes);
            UpdateHistory();
        } finally {
            _enteredRowChanged = false;
        }
    }

    private void UpdateHistory() {
        if (_backupFile.Exists)
            _backupFile.Delete();
        _file.CopyTo(_backupFile.FullName);
        using var stream = _file.Open(FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        using var historyWriter = new StreamWriter(stream);
        foreach (DataRow historyEntry in Rows) {
            historyWriter.Write(historyEntry[0]);
            historyWriter.Write(_columnSeparator);
            historyWriter.Write(historyEntry[1]);
            historyWriter.Write(_separator);
        }
    }
    public override string ToString() => _file.FullName;
}
