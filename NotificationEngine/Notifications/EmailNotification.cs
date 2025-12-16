using NotificationEngine.Templates;

namespace NotificationEngine.Notifications;

public sealed class EmailNotification : INotification
{
    public string BuildMessage(MessageTemplate template)
        => $"{template.Title}\n{template.Body}\n{template.Footer}";
}