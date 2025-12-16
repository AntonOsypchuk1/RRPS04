using NotificationEngine.Providers.Interfaces;
using NotificationEngine.Providers.SendGrid;

namespace NotificationEngine.Factories;

public sealed class SendGridFactory : IProviderFactory
{
    public IEmailSender CreateEmailSender() => new SendGridEmailSender();
    public ISmsSender CreateSmsSender() => new SendGridSmsSender();
}