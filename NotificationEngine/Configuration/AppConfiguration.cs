namespace NotificationEngine.Configuration;

public sealed class AppConfiguration
{
    private static readonly Lazy<AppConfiguration> _instance =
        new(() => new AppConfiguration());

    public static AppConfiguration Instance => _instance.Value;

    public string Provider { get; }

    private AppConfiguration()
    {
        Provider = "Twilio"; // умовно, потім env / file
    }
}