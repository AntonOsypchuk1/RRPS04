using NotificationEngine.Configuration;

namespace NotificationEngine.Factories;

public static class ProviderFactorySelector
{
    public static IProviderFactory Select()
    {
        return AppConfiguration.Instance.Provider switch
        {
            "twilio" => new TwilioFactory(),
            "sendgrid" => new SendGridFactory(),
            _ => throw new InvalidOperationException("Provider factory not configured.")
        };
    }
}