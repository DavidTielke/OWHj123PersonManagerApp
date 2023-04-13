using DavidTielke.OwHj123.CrossCutting.Configuration.Contract.Exceptions;
using DavidTielke.OwHj123.Data.FileStoring.Contract;

namespace DavidTielke.OwHj123.Data.FileStoring;

public class FileStorer : IFileStorer
{
    public string[] Load(string filename)
    {
        try
        {
            return File.ReadAllLines(filename);
        }
        catch (FileNotFoundException exc)
        {
            throw new StoreNotFoundException("Datei war nicht vorhanden", exc);
        }
    }
}