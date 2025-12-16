namespace NotificationEngine.Providers.Twilio;

public class TwilioSmsSender : ISmsSender
{
    public void Send(string message)
    {
        Console.WriteLine($"[Twilio SMS] {message}");
    }
}