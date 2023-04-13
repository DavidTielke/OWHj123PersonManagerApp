namespace FileStoring;

public class FileStorer : IFileStorer
{
    public string[] Load(string filename)
    {
        return File.ReadAllLines(filename);
    }
}