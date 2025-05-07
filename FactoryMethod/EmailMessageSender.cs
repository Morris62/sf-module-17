namespace FactoryMethod;

public class EmailMessageSender(string from) : MessageSender(from)
{
    public override Message Send(string text)
    {
        return new EmailMessage();
    }
}