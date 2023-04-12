using DavidTielke.OwHj123.CrossCutting.DataClasses;
using DavidTielke.OwHj123.Data.DataCsvStoring;

namespace DavidTielke.OwHj123.Logic.Domain.AuditationManagement;

public class AuditEntryManager
{
    private readonly AuditEntryRepository _repository;

    public AuditEntryManager()
    {
        _repository = new AuditEntryRepository();
    }

    public void Add(AuditEntry entry)
    {
        // ...
        _repository.Insert(entry);
    }
}