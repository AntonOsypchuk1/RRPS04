namespace NotificationEngine.Providers;

public interface ISender
{
    void Send(string message);
}