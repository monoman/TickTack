// ******************************************************************************************************************************
// ****
// ****      Copyright (c) 2008-2026 Rafael 'Monoman' Teixeira
// ****
// ******************************************************************************************************************************

using System.Data;
using TickTack;

namespace Tests;

public class HistoryFileTests
{
    private string _folderPath = null!;

    [SetUp]
    public void Setup() {
        _folderPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        _ = Directory.CreateDirectory(_folderPath);
    }

    [TearDown]
    public void TearDown() => Directory.Delete(_folderPath, recursive: true);

    [Test]
    public void Constructor_WhenHistoryFileDoesNotExist_CreatesEmptyTable() {
        var history = new HistoryFile(_folderPath);

        using (Assert.EnterMultipleScope()) {
            Assert.That(history.TableName, Is.EqualTo(nameof(HistoryFile)));
            Assert.That(history.Columns.Cast<DataColumn>().Select(column => column.ColumnName), Is.EqualTo(["Task", "Minutes"]));
            Assert.That(history.Rows, Is.Empty);
        }
    }

    [Test]
    public void Constructor_LoadsSortedUniqueRowsAndDefaultsInvalidMinutes() {
        File.WriteAllText(Path.Combine(_folderPath, "history.txt"), "Write tests|15\nReview code|invalid\nWrite tests|30\nPlan work\n");

        var history = new HistoryFile(_folderPath);

        Assert.That(history.Rows.Cast<DataRow>().Select(row => (Task: (string)row["Task"], Minutes: (int)row["Minutes"])),
            Is.EqualTo([("Plan work", ContentFile.DefaultPeriodInMinutes), ("Review code", ContentFile.DefaultPeriodInMinutes), ("Write tests", 15)]));
    }

    [Test]
    public void AddingRow_PersistsHistoryAndBacksUpPreviousContents() {
        const string originalContents = "Existing task|20\n";
        File.WriteAllText(Path.Combine(_folderPath, "history.txt"), originalContents);
        var history = new HistoryFile(_folderPath);

        _ = history.Rows.Add("New task", 35);

        using (Assert.EnterMultipleScope()) {
            Assert.That(File.ReadAllText(Path.Combine(_folderPath, "history.txt")), Is.EqualTo("Existing task|20\nNew task|35\n"));
            Assert.That(File.ReadAllText(Path.Combine(_folderPath, "history_backup.txt")), Is.EqualTo(originalContents));
        }
    }

    [Test]
    public void AddingRowWithoutMinutes_UsesDefaultPeriodAndPersistsIt() {
        File.WriteAllText(Path.Combine(_folderPath, "history.txt"), "Existing task|20\n");
        var history = new HistoryFile(_folderPath);

        _ = history.Rows.Add("New task");

        using (Assert.EnterMultipleScope()) {
            Assert.That(history.Rows.Cast<DataRow>().Single(row => (string)row["Task"] == "New task")["Minutes"],
                    Is.EqualTo(ContentFile.DefaultPeriodInMinutes));
            Assert.That(File.ReadAllText(Path.Combine(_folderPath, "history.txt")), Is.EqualTo("Existing task|20\nNew task|25\n"));
        }
    }
}