using DavidTielke.OwHj123.CrossCutting.DataClasses;

namespace DavidTielke.OwHj123.Data.DataCsvStoring.Contract;

public interface IAuditEntryRepository
{
    void Insert(AuditEntry entry);
}