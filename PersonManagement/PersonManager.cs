using Configuration;
using DavidTielke.OwHj123.CrossCutting.DataClasses;
using DavidTielke.OwHj123.Data.DataCsvStoring;

namespace DavidTielke.OwHj123.Logic.Domain.PersonManagement;

public class PersonManager : IPersonManager
{
    private readonly IPersonRepository _repository;
    private readonly int AGE_TRESHOLD;

    public PersonManager(IPersonRepository repository, IConfigurator config)
    {
        _repository = repository;
        AGE_TRESHOLD = config.Get<int>("persons.agetreshold");
    }

    public IQueryable<Person> GetAllAdults()
    {
        return _repository.LoadAll().Where(p => p.Age >= AGE_TRESHOLD);
    }

    public IQueryable<Person> GetAllChildren()
    {
        return _repository.LoadAll().Where(p => p.Age < AGE_TRESHOLD);
    }
}