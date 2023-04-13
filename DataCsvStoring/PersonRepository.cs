using Configuration;
using DavidTielke.OwHj123.CrossCutting.DataClasses;
using FileStoring;

namespace DavidTielke.OwHj123.Data.DataCsvStoring;

public class PersonRepository : IPersonRepository
{
    private readonly IPersonParser _parser;
    private readonly IFileStorer _storer;

    private readonly string FILE_PATH;

    public PersonRepository(IPersonParser parser,
        IFileStorer storer, IConfigurator config)
    {
        _parser = parser;
        _storer = storer;
        FILE_PATH = config.Get<string>("person.csvpath");
    }

    public IQueryable<Person> LoadAll()
    {
        var lines = _storer.Load(FILE_PATH);
        var persons = _parser.Parse(lines);
        return persons.AsQueryable();
    }
}