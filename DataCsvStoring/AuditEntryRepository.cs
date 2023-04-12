using DavidTielke.OwHj123.CrossCutting.DataClasses;

namespace DavidTielke.OwHj123.Data.DataCsvStoring;

public class AuditEntryRepository
{
    public void Insert(AuditEntry entry)
    {
        File.AppendAllLines("audit.log", new[] { entry.Message });
    }
}