using AuditationManagement;
using DavidTielke.OwHj123.CrossCutting.DataClasses;
using DavidTielke.OwHj123.Logic.Domain.PersonManagement;

namespace DavidTielke.OwHj123.UI.ConsoleClient;

internal class Program
{
    private static void Main(string[] args)
    {
        var entryManager = new AuditEntryManager();
        entryManager.Add(new AuditEntry { Message = "huhu log...", UserId = "David" });

        var manager = new PersonManager();

        var adults = manager.GetAllAdults().ToList();
        Console.WriteLine($"## Erwachsene({adults.Count}) ##");
        adults.ForEach(p => Console.WriteLine(p.Name));

        var children = manager.GetAllChildren().ToList();
        Console.WriteLine($"## Kinder({children.Count}) ##");
        children.ForEach(p => Console.WriteLine(p.Name));
    }
}