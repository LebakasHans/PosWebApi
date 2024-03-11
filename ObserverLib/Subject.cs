namespace ObserverLib;

public abstract class Subject
{
  private readonly List<IObserver> _observers = [];

  public void Attach(IObserver observer)
  {
    _observers.Add(observer);
    Console.WriteLine($"+++{observer}+++");
  }

  public void Detach(IObserver observer)
  {
    _observers.Remove(observer);
    Console.WriteLine($"---{observer}---");
  }

  protected void Notify()
  {
    foreach (var observer in _observers)
    {
      observer.Update();
    }
  }
}
