namespace NotificationEngine;

public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"[SMS] Sending sms with message: {message}");
    }
}