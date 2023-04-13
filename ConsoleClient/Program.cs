using Configuration;
using Mappings;
using Ninject;
using Workflows;

namespace DavidTielke.OwHj123.UI.ConsoleClient;

internal class Program
{
    private static void Main(string[] args)
    {
        var kernel = new KernelFactory().Create();

        var config = kernel.Get<IConfigurator>();
        config.Set("person.csvpath", "data.csv");
        config.Set("persons.agetreshold", 10);

        var workflow = kernel.Get<IPersonManagementWorkflows>();

        var adults = workflow.RunGetAllAdults("david").ToList();
        Console.WriteLine($"## Erwachsene({adults.Count}) ##");
        adults.ForEach(p => Console.WriteLine(p.Name));

        var children = workflow.RunGetAllChildren("david").ToList();
        Console.WriteLine($"## Kinder({children.Count}) ##");
        children.ForEach(p => Console.WriteLine(p.Name));
    }
}