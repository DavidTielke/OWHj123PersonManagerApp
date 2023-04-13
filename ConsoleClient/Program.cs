using DavidTielke.OwHj123.CrossCutting.Configuration.Contract;
using DavidTielke.OwHj123.Infrastructure.Mappings;
using DavidTielke.OwHj123.Log.Business.Workflows.Contract;
using Ninject;

namespace DavidTielke.OwHj123.UI.ConsoleClient;

internal class Program
{
    private static void Main(string[] args)
    {
        var kernel = new KernelFactory().Create();

        var config = kernel.Get<IConfigurator>();
        config.Set("person.csvpath", "data.csv");
        config.Set("persons.agetreshold", 10);
        config.Set("user.id", "Lisa");

        var workflow = kernel.Get<IPersonManagementWorkflows>();

        var adults = workflow.RunGetAllAdults().ToList();
        Console.WriteLine($"## Erwachsene({adults.Count}) ##");
        adults.ForEach(p => Console.WriteLine(p.Name));

        var children = workflow.RunGetAllChildren().ToList();
        Console.WriteLine($"## Kinder({children.Count}) ##");
        children.ForEach(p => Console.WriteLine(p.Name));
    }
}