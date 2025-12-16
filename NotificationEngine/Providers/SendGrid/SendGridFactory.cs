namespace NotificationEngine.Providers.SendGrid;

public class SendGridFactory : IProviderFactory
{
    public IEmailSender CreateEmailSender() => new SendGridEmailSender();
    public ISmsSender CreateSmsSender() => new SendGridSmsSender();
}