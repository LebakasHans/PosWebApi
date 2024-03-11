using ObserverLib;
using SchoolDbLib;

namespace WebApiCodeFirst.Services;

public class DbLogObserver(LogSubject logSubject) : BackgroundService, IObserver
{
    public void Update()
    {
        throw new NotImplementedException();
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logSubject.Attach(this);
        return Task.CompletedTask;
    }
}
