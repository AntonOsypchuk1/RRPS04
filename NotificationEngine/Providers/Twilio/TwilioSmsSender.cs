using NotificationEngine.Providers.Interfaces;

namespace NotificationEngine.Providers.Twilio;

public sealed class TwilioSmsSender : ISmsSender
{
    public void Send(string message) => Console.WriteLine($"[Twilio SMS] {message}");
}