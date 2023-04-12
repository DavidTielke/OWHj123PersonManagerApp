namespace DavidTielke.OwHj123.ConsoleClient;

public class PersonRepository
{
    private readonly PersonParser _parser;

    public PersonRepository()
    {
        _parser = new PersonParser();
    }

    public IQueryable<Person> LoadAll()
    {
        var persons = _parser.Parse("data.csv");
        return persons.AsQueryable();
    }
}