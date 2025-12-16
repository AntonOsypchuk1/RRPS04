namespace NotificationEngine.Providers.Twilio;

public class TwilioEmailSender : IEmailSender
{
    public void Send(string message)
    {
        Console.WriteLine($"[Twilio EMAIL] {message}");
    }
}