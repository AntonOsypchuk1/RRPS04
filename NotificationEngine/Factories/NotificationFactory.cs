using NotificationEngine.Notifications;

namespace NotificationEngine.Factories;

public static class NotificationFactory
{
    public static INotification Create(string? type)
    {
        type = type?.Trim().ToLowerInvariant();

        return type switch
        {
            "email" => new EmailNotification(),
            "sms" => new SmsNotification(),
            _ => throw new ArgumentException("Unknown notification type (use email/sms).")
        };
    }
}