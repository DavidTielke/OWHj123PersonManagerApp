using DavidTielke.OwHj123.CrossCutting.Configuration.Contract;

namespace DavidTielke.OwHj123.CrossCutting.Configuration;

public class Configurator : IConfigurator
{
    private readonly Dictionary<string, object> _items;

    public Configurator()
    {
        _items = new Dictionary<string, object>();
    }

    public void Set(string key, object value)
    {
        _items[key] = value;
    }

    public TItem Get<TItem>(string key)
    {
        return (TItem)_items[key];
    }
}