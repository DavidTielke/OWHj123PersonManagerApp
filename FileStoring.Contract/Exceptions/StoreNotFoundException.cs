namespace DavidTielke.OwHj123.CrossCutting.Configuration.Contract.Exceptions;

public class StoreNotFoundException : FileStoringException
{
    public StoreNotFoundException()
    {
    }

    public StoreNotFoundException(string message) : base(message)
    {
    }

    public StoreNotFoundException(string message, Exception inner) : base(message, inner)
    {
    }
}