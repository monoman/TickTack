// ******************************************************************************************************************************
// ****
// ****      Copyright (c) 2008-2024 Rafael 'Monoman' Teixeira
// ****
// ******************************************************************************************************************************


using System.Data;

namespace TickTack;

public record HistoryEntry(string? History);

public class HistoryFile : DataTable
{
    private const char _separator = '\n';
    private readonly FileInfo _file;

    public HistoryFile(string folderPath) {
        _file = new(Path.Combine(folderPath, "history.txt"));
        BeginLoadData();
        Columns.Clear();
        Columns.Add(new DataColumn() { DataType = typeof(string), AllowDBNull = false, ColumnName = "History" });
        Rows.Clear();
        foreach (var row in _allRows)
            Rows.Add(row);
        EndLoadData();
        TableName = nameof(HistoryFile);
        TableCleared += HistoryFile_TableCleared;
        RowDeleted += HistoryFile_RowChanged;
        RowChanged += HistoryFile_RowChanged;
        UpdateHistory();
    }


    private IEnumerable<string> _allRows {
        get {
            List<string> rows = [];
            if (_file.Exists) {
                using var streamReader = _file.OpenText();
                rows.AddRange(streamReader.ReadToEnd().Split(_separator, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).Distinct());
            }
            if (rows.Count == 0)
                rows.Add(ContentFile.DefaultContent);
            return rows;
        }
    }

    private void HistoryFile_RowChanged(object sender, DataRowChangeEventArgs e) => UpdateHistory();
    private void HistoryFile_TableCleared(object sender, DataTableClearEventArgs e) => UpdateHistory();

    private void UpdateHistory() {
        using var stream = _file.Open(FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        using var historyWriter = new StreamWriter(stream);
        foreach (DataRow historyEntry in Rows) {
            historyWriter.Write(historyEntry[0]);
            historyWriter.Write(_separator);
        }
    }
    public override string ToString() => _file.FullName;
}
