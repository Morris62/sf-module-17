namespace FactoryMethod;

public abstract class MessageSender(string from)
{
    public string From { get; set; } = from;

    public abstract Message Send(string text);
}