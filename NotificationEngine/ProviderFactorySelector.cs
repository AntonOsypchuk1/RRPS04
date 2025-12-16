using NotificationEngine.Configuration;
using NotificationEngine.Factories;

namespace NotificationEngine;

public static class ProviderFactorySelector
{
    public static IProviderFactory Select()
    {
        var provider = AppConfiguration.Instance.Provider;

        return provider switch
        {
            "Twilio" => new TwilioFactory(),
            "SendGrid" => new SendGridFactory(),
            _ => throw new InvalidOperationException("Unknown provider")
        };
    }
}