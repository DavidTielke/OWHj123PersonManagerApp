namespace FileStoring;

public interface IFileStorer
{
    string[] Load(string filename);
}