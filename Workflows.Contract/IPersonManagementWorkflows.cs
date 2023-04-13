using DavidTielke.OwHj123.CrossCutting.DataClasses;

namespace DavidTielke.OwHj123.Log.Business.Workflows.Contract;

public interface IPersonManagementWorkflows
{
    IQueryable<Person> RunGetAllAdults();
    IQueryable<Person> RunGetAllChildren();
}