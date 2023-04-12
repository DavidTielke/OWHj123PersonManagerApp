using DavidTielke.OwHj123.CrossCutting.DataClasses;

namespace DavidTielke.OwHj123.Data.DataCsvStoring;

public class PersonParser
{
    public IEnumerable<Person> Parse(string path)
    {
        var persons = File.ReadAllLines(path)
            .Select(l => l.Split(","))
            .Select(p => new Person
            {
                Id = int.Parse(p[0]),
                Name = p[1],
                Age = int.Parse(p[2])
            });
        return persons;
    }
}