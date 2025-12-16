namespace NotificationEngine.Configuration;

public sealed class AppConfiguration
{
    private static readonly Lazy<AppConfiguration> _instance =
        new(() => new AppConfiguration());

    public static AppConfiguration Instance => _instance.Value;

    public string Provider { get; private set; } = "twilio";

    private AppConfiguration() { }

    public void SetProvider(string? provider)
    {
        if (string.IsNullOrWhiteSpace(provider))
            return;

        provider = provider.Trim().ToLowerInvariant();

        Provider = provider switch
        {
            "twilio" => "twilio",
            "sendgrid" => "sendgrid",
            _ => throw new InvalidOperationException("Unknown provider (use twilio/sendgrid).")
        };
    }
}