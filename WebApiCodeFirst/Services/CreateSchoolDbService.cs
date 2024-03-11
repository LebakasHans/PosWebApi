
using SchoolDbLib;

namespace WebApiCodeFirst.Services;

public class CreateSchoolDbService(IServiceProvider serviceProvider) : BackgroundService
{
  protected override Task ExecuteAsync(CancellationToken stoppingToken) { 
  var scope = serviceProvider.CreateScope();
    var db = scope.ServiceProvider.GetRequiredService<SchoolContext>();
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();
    AssertDbSeeded();

    return Task.CompletedTask;
  }

  private void AssertDbSeeded() { 
    
  }
}
