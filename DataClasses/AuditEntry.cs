namespace DavidTielke.OwHj123.CrossCutting.DataClasses;

public class AuditEntry
{
    public AuditEntry()
    {
    }

    public AuditEntry(string userId, string message)
    {
        UserId = userId;
        Message = message;
    }

    public string UserId { get; set; }
    public string Message { get; set; }
}