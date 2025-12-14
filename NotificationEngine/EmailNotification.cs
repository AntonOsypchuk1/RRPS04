namespace NotificationEngine;

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"[EMAIL] Sending email with message: {message}");
    }
}