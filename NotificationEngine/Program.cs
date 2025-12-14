namespace NotificationEngine;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose notification type (email / sms):");
        var type = Console.ReadLine();

        Console.WriteLine("Enter message:");
        var message = Console.ReadLine();

        try
        {
            var notification = NotificationFactory.Create(type);
            notification.Send(message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}