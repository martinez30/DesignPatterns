using Observer.Interfaces;

namespace Observer.Entities;

public class Client : IObserver
{
    public string Name { get; set; }
    public string Email { get; set; }
    private ISubject Subject { get; set; }
    
    public Client(string name, string email, ISubject subject)
    {
        Name = name;
        Email = email;
        Subject = subject;
        Subject.registerObserver(this);
    }


    public void update(string message)
    {
        EmailService.sendEmail(this, message);
    }
}