namespace NotificationEngine.Providers.SendGrid;

public class SendGridEmailSender : IEmailSender
{
    public void Send(string message)
    {
        Console.WriteLine($"[SendGrid EMAIL] {message}");
    }
}