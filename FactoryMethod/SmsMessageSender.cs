namespace FactoryMethod;

public class SmsMessageSender(string from) : MessageSender(from)
{
    public override Message Send(string text)
    {
        return new SmsMessage();
    }
}