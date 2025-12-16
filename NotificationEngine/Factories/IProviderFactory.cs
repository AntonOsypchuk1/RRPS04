using NotificationEngine.Providers.Interfaces;

namespace NotificationEngine.Factories;

public interface IProviderFactory
{
    IEmailSender CreateEmailSender();
    ISmsSender CreateSmsSender();
}