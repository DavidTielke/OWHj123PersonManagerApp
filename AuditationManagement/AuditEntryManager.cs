using DavidTielke.OwHj123.CrossCutting.DataClasses;
using DavidTielke.OwHj123.Data.DataCsvStoring;

namespace DavidTielke.OwHj123.Logic.Domain.AuditationManagement;

public class AuditEntryManager : IAuditEntryManager
{
    private readonly IAuditEntryRepository _repository;

    public AuditEntryManager(IAuditEntryRepository repository)
    {
        _repository = repository;
    }

    public void Add(AuditEntry entry)
    {
        // ...
        _repository.Insert(entry);
    }
}