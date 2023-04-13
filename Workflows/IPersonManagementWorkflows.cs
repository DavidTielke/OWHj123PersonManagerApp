using DavidTielke.OwHj123.CrossCutting.DataClasses;

namespace Workflows;

public interface IPersonManagementWorkflows
{
    IQueryable<Person> RunGetAllAdults();
    IQueryable<Person> RunGetAllChildren();
}