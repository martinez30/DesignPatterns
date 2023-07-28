namespace Observer.Interfaces;

public interface IObserver
{
    public string Name { get; set; }
    public string Email { get; set; }
    
    void update(string message);
}