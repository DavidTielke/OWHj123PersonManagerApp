using DavidTielke.OwHj123.CrossCutting.DataClasses;
using DavidTielke.OwHj123.Logic.Domain.AuditationManagement;
using DavidTielke.OwHj123.Logic.Domain.PersonManagement;

namespace Workflows;

public class PersonManagementWorkflows : IPersonManagementWorkflows
{
    private readonly IAuditEntryManager _auditEntryManager;
    private readonly IPersonManager _personManager;

    public PersonManagementWorkflows(IAuditEntryManager auditEntryManager,
        IPersonManager personManager)
    {
        _auditEntryManager = auditEntryManager;
        _personManager = personManager;
    }

    public IQueryable<Person> RunGetAllAdults(string userId)
    {
        var adults = _personManager.GetAllAdults();
        _auditEntryManager.Add(new AuditEntry(userId, "Erwachsene geladen"));
        return adults;
    }

    public IQueryable<Person> RunGetAllChildren(string userId)
    {
        var children = _personManager.GetAllChildren();
        _auditEntryManager.Add(new AuditEntry(userId, "Kinder geladen"));
        return children;
    }
}