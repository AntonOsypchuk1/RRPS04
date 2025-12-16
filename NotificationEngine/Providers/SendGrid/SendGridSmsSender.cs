using NotificationEngine.Providers.Interfaces;

namespace NotificationEngine.Providers.SendGrid;

public sealed class SendGridSmsSender : ISmsSender
{
    public void Send(string message) => Console.WriteLine($"[SendGrid SMS] {message}");
}