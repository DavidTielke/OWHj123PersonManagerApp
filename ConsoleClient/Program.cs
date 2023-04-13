using DavidTielke.OwHj123.Data.DataCsvStoring;
using DavidTielke.OwHj123.Logic.Domain.AuditationManagement;
using DavidTielke.OwHj123.Logic.Domain.PersonManagement;
using FileStoring;
using Workflows;

namespace DavidTielke.OwHj123.UI.ConsoleClient;

internal class Program
{
    private static void Main(string[] args)
    {
        var auditRepository = new AuditEntryRepository();
        var auditManager = new AuditEntryManager(auditRepository);

        var personParser = new PersonParser();
        var fileStorer = new FileStorer();
        var personRepository = new PersonRepository(personParser, fileStorer);
        var personManager = new PersonManager(personRepository);

        var workflow = new PersonManagementWorkflows(auditManager, personManager);

        var adults = workflow.RunGetAllAdults("david").ToList();
        Console.WriteLine($"## Erwachsene({adults.Count}) ##");
        adults.ForEach(p => Console.WriteLine(p.Name));

        var children = workflow.RunGetAllChildren("david").ToList();
        Console.WriteLine($"## Kinder({children.Count}) ##");
        children.ForEach(p => Console.WriteLine(p.Name));
    }
}