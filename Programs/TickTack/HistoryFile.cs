// ******************************************************************************************************************************
// ****
// ****      Copyright (c) 2008-2024 Rafael 'Monoman' Teixeira
// ****
// ******************************************************************************************************************************

using System.Collections;

namespace TickTack;

public class HistoryFile(string folderPath)
{

    private readonly FileInfo _file = new FileInfo(Path.Combine(folderPath, "history.txt"));
    public bool Exists => _file.Exists;
    public string[] ReadHistory() {
        using var streamReader = _file.OpenText();
        var historyEntries = streamReader.ReadToEnd().Split('\n', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
        return historyEntries.Distinct().ToArray();
    }

    public void UpdateHistory(IEnumerable historyEntries) {
        using var stream = _file.Open(FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        using var historyWriter = new StreamWriter(stream);
        foreach (var historyEntry in historyEntries.Cast<string>().Distinct()) {
            historyWriter.WriteLine(historyEntry);
        }
    }
    public override string ToString() => _file.FullName;
}
