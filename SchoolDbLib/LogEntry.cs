namespace SchoolDbLib;

public class LogEntry
{
    public int Id { get; set; }
    public string ControllerName { get; set; } = null!;
    public string ActionName { get; set; } = null!;
    public DateTime LoggedAt { get; set; }
}
