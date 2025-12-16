using NotificationEngine.Configuration;
using NotificationEngine.Factories;
using NotificationEngine.Providers.Interfaces;
using NotificationEngine.Services;
using NotificationEngine.Templates;

namespace NotificationEngine;

internal static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Provider (twilio / sendgrid):");
        var providerInput = Console.ReadLine()?.Trim().ToLowerInvariant();

        Console.WriteLine("Notification type (email / sms):");
        var typeInput = Console.ReadLine()?.Trim().ToLowerInvariant();

        Console.WriteLine("Message body:");
        var body = Console.ReadLine() ?? string.Empty;
        
        try
        {
            // Config (Singleton)
            AppConfiguration.Instance.SetProvider(providerInput);

            // Prototype (clone base template + customize)
            var templateKey = typeInput == "sms" ? "default_sms" : "default_email";
            var template = TemplateRegistry.Get(templateKey);
            template.Body = body;

            // Factory Method (create notification)
            var notification = NotificationFactory.Create(typeInput);

            // Abstract Factory (select provider family + create sender)
            var providerFactory = ProviderFactorySelector.Select();
            ISender sender = typeInput == "sms"
                ? providerFactory.CreateSmsSender()
                : providerFactory.CreateEmailSender();

            // Orchestration
            var service = new NotificationService();
            service.Send(notification, sender, template);

            Console.WriteLine("Done.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}