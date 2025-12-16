using NotificationEngine.Factories;
using NotificationEngine.Notifications;

namespace NotificationEngine;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose notification type (email / sms):");
        var type = Console.ReadLine();

        Console.WriteLine("Enter message:");
        var message = Console.ReadLine();

        var notification = NotificationFactory.Create(type);

        var providerFactory = ProviderFactorySelector.Select();
        var sender = providerFactory.CreateEmailSender();

        var service = new NotificationService();
        service.Send(notification, sender);
    }
}