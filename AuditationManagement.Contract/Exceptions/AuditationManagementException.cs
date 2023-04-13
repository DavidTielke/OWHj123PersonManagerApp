namespace DavidTielke.OwHj123.CrossCutting.Configuration.Contract.Exceptions;

public class AuditationManagementException : Exception
{
    public AuditationManagementException()
    {
    }

    public AuditationManagementException(string message) : base(message)
    {
    }

    public AuditationManagementException(string message, Exception inner) : base(message, inner)
    {
    }
}