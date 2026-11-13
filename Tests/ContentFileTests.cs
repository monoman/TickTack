// ******************************************************************************************************************************
// ****
// ****      Copyright (c) 2008-2026 Rafael 'Monoman' Teixeira
// ****
// ******************************************************************************************************************************

using TickTack;

namespace Tests;

public class ContentFileTests
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
    public void ReadContent_WhenFileDoesNotExist_ReturnsDefaults() {
        var contentFile = new ContentFile(_folderPath);

        var result = contentFile.ReadContent();

        Assert.That(result, Is.EqualTo((ContentFile.DefaultContent, ContentFile.DefaultPeriodInMinutes)));
    }

    [Test]
    public void UpdateContent_WritesContentAndMinutesThatCanBeReadBack() {
        var contentFile = new ContentFile(_folderPath);

        var updated = contentFile.UpdateContent("Review notes", 40);
        var read = new ContentFile(_folderPath).ReadContent();

        using (Assert.EnterMultipleScope()) {
            Assert.That(updated, Is.EqualTo(("Review notes", 40)));
            Assert.That(read, Is.EqualTo(("Review notes", 40)));
        }
    }

    [TestCase(null)]
    [TestCase("")]
    [TestCase("   ")]
    public void UpdateContent_WhenTextIsNullOrWhitespace_UsesDefaultContent(string? text) {
        var contentFile = new ContentFile(_folderPath);

        var result = contentFile.UpdateContent(text, 30);

        using (Assert.EnterMultipleScope()) {
            Assert.That(result, Is.EqualTo((ContentFile.DefaultContent, 30)));
            Assert.That(new ContentFile(_folderPath).ReadContent(), Is.EqualTo(result));
        }
    }
}