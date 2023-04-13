namespace DavidTielke.OwHj123.CrossCutting.Configuration.Contract.Exceptions;

public class FileStoringException : Exception
{
    public FileStoringException()
    {
    }

    public FileStoringException(string message) : base(message)
    {
    }

    public FileStoringException(string message, Exception inner) : base(message, inner)
    {
    }
}