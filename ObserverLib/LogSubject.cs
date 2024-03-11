namespace ObserverLib;
public class LogSubject : Subject
{
    private LogDto state;
    public LogDto State
    {
        get => state;
        set
        {
            state = value;
            Notify();
        }
    }
}
