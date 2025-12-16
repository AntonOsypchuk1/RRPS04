using NotificationEngine.Providers.Interfaces;

namespace NotificationEngine.Providers.Twilio;

public sealed class TwilioEmailSender : IEmailSender
{
    public void Send(string message) => Console.WriteLine($"[Twilio EMAIL]\n{message}\n");
}