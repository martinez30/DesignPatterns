using Observer.Interfaces;

namespace Observer;

public class EmailService
{
    public static void sendEmail(IObserver observer, string message) =>
        Console.WriteLine($"Email enviado para {observer.Email} com a mensagem: {message}");
}