namespace DavidTielke.OwHj123.CrossCutting.Configuration.Contract.Exceptions;

public class PersonManagementException : Exception
{
    public PersonManagementException()
    {
    }

    public PersonManagementException(string message) : base(message)
    {
    }

    public PersonManagementException(string message, Exception inner) : base(message, inner)
    {
    }
}