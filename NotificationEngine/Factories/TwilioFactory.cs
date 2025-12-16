using NotificationEngine.Providers.Interfaces;
using NotificationEngine.Providers.Twilio;

namespace NotificationEngine.Factories;

public sealed class TwilioFactory : IProviderFactory
{
    public IEmailSender CreateEmailSender() => new TwilioEmailSender();
    public ISmsSender CreateSmsSender() => new TwilioSmsSender();
}