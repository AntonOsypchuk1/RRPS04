using NotificationEngine.Templates;

namespace NotificationEngine.Notifications;

public interface INotification
{
    string BuildMessage(MessageTemplate template);
}