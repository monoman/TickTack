// ******************************************************************************************************************************
// ****
// ****      Copyright (c) 2008-2024 Rafael 'Monoman' Teixeira
// ****
// ******************************************************************************************************************************

namespace TickTack;

public class ContentFile(string folderPath)
{

    private readonly FileInfo _file = new FileInfo(Path.Combine(folderPath, "content.txt"));

    public bool Exists => _file.Exists;
    public string ReadContent() {
        using var streamReader = _file.OpenText();
        return streamReader.ReadToEnd();
    }

    public void UpdateContent(string text) {
        using var stream = _file.Open(FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
        using var writer = new StreamWriter(stream);
        writer.Write(text);
    }
    public override string ToString() => _file.FullName;
}
