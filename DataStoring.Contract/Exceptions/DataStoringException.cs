namespace DavidTielke.OwHj123.CrossCutting.Configuration.Contract.Exceptions;

public class DataStoringException : Exception
{
    public DataStoringException()
    {
    }

    public DataStoringException(string message) : base(message)
    {
    }

    public DataStoringException(string message, Exception inner) : base(message, inner)
    {
    }
}