using NotificationEngine.Templates;

namespace NotificationEngine.Notifications;

public sealed class SmsNotification : INotification
{
    public string BuildMessage(MessageTemplate template)
        => $"{template.Title}: {template.Body}";
}