namespace NotificationEngine.Templates;

public class MessageTemplate : IPrototype<MessageTemplate>
{
    public string Title { get; set; }
    public string Body { get; set; }
    public string Footer { get; set; }
    public string Language { get; set; }

    public MessageTemplate Clone()
    {
        return new MessageTemplate
        {
            Title = Title,
            Body = Body,
            Footer = Footer,
            Language = Language
        };
    }
}