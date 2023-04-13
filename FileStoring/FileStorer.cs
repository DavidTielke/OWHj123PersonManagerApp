using DavidTielke.OwHj123.Data.FileStoring.Contract;

namespace DavidTielke.OwHj123.Data.FileStoring;

public class FileStorer : IFileStorer
{
    public string[] Load(string filename)
    {
        return File.ReadAllLines(filename);
    }
}