namespace NotificationEngine.Providers.Twilio;

public class TwilioFactory : IProviderFactory
{
    public IEmailSender CreateEmailSender()
    {
        return new TwilioEmailSender();
    }

    public ISmsSender CreateSmsSender()
    {
        return new TwilioSmsSender();
    }
}