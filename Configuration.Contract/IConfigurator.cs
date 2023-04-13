namespace DavidTielke.OwHj123.CrossCutting.Configuration.Contract;

public interface IConfigurator
{
    void Set(string key, object value);
    TItem Get<TItem>(string key);
}