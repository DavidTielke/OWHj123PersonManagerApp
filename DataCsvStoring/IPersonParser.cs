using DavidTielke.OwHj123.CrossCutting.DataClasses;

namespace DavidTielke.OwHj123.Data.DataCsvStoring;

public interface IPersonParser
{
    IEnumerable<Person> Parse(IEnumerable<string> lines);
}