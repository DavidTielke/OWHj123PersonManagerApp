namespace DavidTielke.OwHj123.Data.FileStoring.Contract;

public interface IFileStorer
{
    string[] Load(string filename);
}