using DavidTielke.OwHj123.CrossCutting.Configuration.Contract;
using DavidTielke.OwHj123.CrossCutting.DataClasses;
using DavidTielke.OwHj123.Log.Business.Workflows.Contract;
using DavidTielke.OwHj123.Logic.Domain.AuditationManagement.Contract;
using DavidTielke.OwHj123.Logic.Domain.PersonManagement.Contract;

namespace DavidTielke.OwHj123.Log.Business.Workflows;

public class PersonManagementWorkflows : IPersonManagementWorkflows
{
    private readonly IAuditEntryManager _auditEntryManager;
    private readonly IPersonManager _personManager;

    private readonly string USER_ID;

    public PersonManagementWorkflows(IAuditEntryManager auditEntryManager,
        IPersonManager personManager, IConfigurator config)
    {
        _auditEntryManager = auditEntryManager;
        _personManager = personManager;

        USER_ID = config.Get<string>("user.id");
    }

    public IQueryable<Person> RunGetAllAdults()
    {
        var adults = _personManager.GetAllAdults();
        _auditEntryManager.Add(new AuditEntry(USER_ID, "Erwachsene geladen"));
        return adults;
    }

    public IQueryable<Person> RunGetAllChildren()
    {
        var children = _personManager.GetAllChildren();
        _auditEntryManager.Add(new AuditEntry(USER_ID, "Kinder geladen"));
        return children;
    }
}