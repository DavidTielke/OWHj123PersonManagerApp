using DavidTielke.OwHj123.CrossCutting.DataClasses;

namespace DavidTielke.OwHj123.Data.DataCsvStoring;

public interface IPersonRepository
{
    IQueryable<Person> LoadAll();
}