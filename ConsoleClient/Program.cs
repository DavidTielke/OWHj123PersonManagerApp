using DavidTielke.OwHj123.Data.DataCsvStoring;
using DavidTielke.OwHj123.Logic.Domain.AuditationManagement;
using DavidTielke.OwHj123.Logic.Domain.PersonManagement;
using FileStoring;
using Ninject;
using Workflows;

namespace DavidTielke.OwHj123.UI.ConsoleClient;

internal class Program
{
    private static void Main(string[] args)
    {
        var kernel = new StandardKernel();

        kernel.Bind<IPersonManagementWorkflows>().To<PersonManagementWorkflows>();
        kernel.Bind<IAuditEntryManager>().To<AuditEntryManager>();
        kernel.Bind<IAuditEntryRepository>().To<AuditEntryRepository>();
        kernel.Bind<IPersonManager>().To<PersonManager>();
        kernel.Bind<IPersonRepository>().To<PersonRepository>();
        kernel.Bind<IPersonParser>().To<PersonParser>();
        kernel.Bind<IFileStorer>().To<FileStorer>();

        var workflow = kernel.Get<IPersonManagementWorkflows>();

        var adults = workflow.RunGetAllAdults("david").ToList();
        Console.WriteLine($"## Erwachsene({adults.Count}) ##");
        adults.ForEach(p => Console.WriteLine(p.Name));

        var children = workflow.RunGetAllChildren("david").ToList();
        Console.WriteLine($"## Kinder({children.Count}) ##");
        children.ForEach(p => Console.WriteLine(p.Name));
    }
}