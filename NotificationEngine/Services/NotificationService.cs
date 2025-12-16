using NotificationEngine.Notifications;
using NotificationEngine.Providers.Interfaces;
using NotificationEngine.Templates;

namespace NotificationEngine.Services;

public sealed class NotificationService : INotificationService
{
    public void Send(INotification notification, ISender sender, MessageTemplate template)
    {
        var message = notification.BuildMessage(template);
        sender.Send(message);
    }
}