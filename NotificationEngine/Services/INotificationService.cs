using NotificationEngine.Notifications;
using NotificationEngine.Providers.Interfaces;
using NotificationEngine.Templates;

namespace NotificationEngine.Services;

public interface INotificationService
{
    void Send(INotification notification, ISender sender, MessageTemplate template);
}