namespace NotificationEngine.Templates;

public interface IPrototype<T>
{
    T Clone();
}