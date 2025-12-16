namespace NotificationEngine.Providers.SendGrid;

public class SendGridSmsSender : ISmsSender
{
    public void Send(string message)
    {
        Console.WriteLine($"[SendGrid SMS] {message}");
    }
}