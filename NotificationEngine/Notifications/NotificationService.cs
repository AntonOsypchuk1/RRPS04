using NotificationEngine.Providers;

namespace NotificationEngine.Notifications;

public class NotificationService : INotificationService
{
    public void Send(INotification notification, ISender sender)
    {
        var message = notification.BuildMessage();
        sender.Send(message);
    }
}