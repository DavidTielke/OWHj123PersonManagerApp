using DavidTielke.OwHj123.Logic.PersonManagement;

namespace DavidTielke.OwHj123.UI.ConsoleClient;

internal class Program
{
    private static void Main(string[] args)
    {
        var manager = new PersonManager();

        var adults = manager.GetAllAdults().ToList();
        Console.WriteLine($"## Erwachsene({adults.Count}) ##");
        adults.ForEach(p => Console.WriteLine(p.Name));

        var children = manager.GetAllChildren().ToList();
        Console.WriteLine($"## Kinder({children.Count}) ##");
        children.ForEach(p => Console.WriteLine(p.Name));
    }
}