namespace NotificationEngine.Providers;

public interface IProviderFactory
{
    IEmailSender CreateEmailSender();
    ISmsSender CreateSmsSender();
}