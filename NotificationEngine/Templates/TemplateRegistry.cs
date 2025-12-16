namespace NotificationEngine.Templates;

public static class TemplateRegistry
{
    // Read-only after initialization
    private static readonly Dictionary<string, MessageTemplate> _templates =
        new(StringComparer.OrdinalIgnoreCase)
        {
            ["default_email"] = new MessageTemplate
            {
                Title = "Hello!",
                Body = "Default email body",
                Footer = "Best regards",
                Language = "en"
            },
            ["default_sms"] = new MessageTemplate
            {
                Title = "Hi",
                Body = "Default sms body",
                Footer = "",
                Language = "en"
            }
        };

    public static MessageTemplate Get(string key)
    {
        if (!_templates.TryGetValue(key, out var template))
            throw new KeyNotFoundException($"Template '{key}' not found.");

        return template.Clone();
    }
}