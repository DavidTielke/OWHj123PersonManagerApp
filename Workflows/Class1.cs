using DavidTielke.OwHj123.CrossCutting.DataClasses;
using DavidTielke.OwHj123.Logic.Domain.AuditationManagement;
using DavidTielke.OwHj123.Logic.Domain.PersonManagement;

namespace Workflows;

public class PersonManagementWorkflows
{
    private readonly AuditEntryManager _auditEntryManager;
    private readonly PersonManager _personManager;

    public PersonManagementWorkflows()
    {
        _personManager = new PersonManager();
        _auditEntryManager = new AuditEntryManager();
    }

    public IQueryable<Person> RunGetAllAdults()
    {
        var adults = _personManager.GetAllAdults();
        _auditEntryManager.Add(new AuditEntry("David", "Erwachsene geladen"));
        return adults;
    }

    public IQueryable<Person> RunGetAllChildren()
    {
        var children = _personManager.GetAllChildren();
        _auditEntryManager.Add(new AuditEntry("David", "Kinder geladen"));
        return children;
    }
}