using NotificationEngine.Providers.Interfaces;

namespace NotificationEngine.Providers.SendGrid;

public sealed class SendGridEmailSender : IEmailSender
{
    public void Send(string message) => Console.WriteLine($"[SendGrid EMAIL]\n{message}\n");
}