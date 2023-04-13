namespace DavidTielke.OwHj123.CrossCutting.Configuration.Contract.Exceptions;

public class WorkflowsException : Exception
{
    public WorkflowsException()
    {
    }

    public WorkflowsException(string message) : base(message)
    {
    }

    public WorkflowsException(string message, Exception inner) : base(message, inner)
    {
    }
}