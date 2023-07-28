using Observer.Interfaces;

namespace Observer;

public class Newsletters : ISubject
{
    private List<IObserver> _observers { get; set; }
    private List<string> _messages { get; set; }

    public Newsletters()
    {
        _observers = new List<IObserver>();
        _messages = new List<string>();
    }
    
    public void registerObserver(IObserver o)
    {
        _observers.Add(o);
    }

    public void removeObserver(IObserver o)
    {
        _observers.Remove(o);
    }

    public void notifyObservers()
    {
        foreach (IObserver o in _observers)
        {
            o.update(_messages.Last());
        }
    }

    public void addMessage(string message)
    {
        _messages.Add(message);
        notifyObservers();
    }
}