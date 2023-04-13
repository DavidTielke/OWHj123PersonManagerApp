using DavidTielke.OwHj123.CrossCutting.DataClasses;
using FileStoring;

namespace DavidTielke.OwHj123.Data.DataCsvStoring;

public class PersonRepository : IPersonRepository
{
    private readonly IPersonParser _parser;
    private readonly IFileStorer _storer;

    public PersonRepository(IPersonParser parser,
        IFileStorer storer)
    {
        _parser = parser;
        _storer = storer;
    }

    public IQueryable<Person> LoadAll()
    {
        var lines = _storer.Load("data.csv");
        var persons = _parser.Parse(lines);
        return persons.AsQueryable();
    }
}