// ******************************************************************************************************************************
// ****
// ****      Copyright (c) 2008-2024 Rafael 'Monoman' Teixeira
// ****
// ******************************************************************************************************************************

using System.Globalization;

namespace TickTack;

public class ContentFile(string folderPath)
{

    private readonly FileInfo _file = new(Path.Combine(folderPath, "content.txt"));
    public const string DefaultContent = "Personal - Done for today?";
    public const int DefaultPeriodInMinutes = 25;
    private const char _separator = '|';

    public (string, int) ReadContent() {
        if (!_file.Exists)
            return (DefaultContent, DefaultPeriodInMinutes);
        using var streamReader = _file.OpenText();
        string[] contentParts = streamReader.ReadToEnd().Split(_separator);
        return (contentParts[0].WithDefault(DefaultContent), contentParts.Length > 1 ? int.Parse(contentParts[1], CultureInfo.InvariantCulture) : DefaultPeriodInMinutes);
    }

    public (string, int) UpdateContent(string? text, int minutes) {
        var newText = text.WithDefault(DefaultContent);
        using var stream = _file.Open(FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        using var writer = new StreamWriter(stream);
        writer.Write(newText);
        writer.Write(_separator);
        writer.Write(minutes.ToString(CultureInfo.InvariantCulture));
        return (newText, minutes);
    }

    public override string ToString() => _file.FullName;
}
