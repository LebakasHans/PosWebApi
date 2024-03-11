namespace ObserverLib;

public class LogDto
{
    public string ControllerName { get; set; } = null!;
    public string ActionName { get; set; } = null!;
    public DateTime LoggedAt { get; set; }
}
