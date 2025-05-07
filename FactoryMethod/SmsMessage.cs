namespace FactoryMethod;

public class SmsMessage : Message
{
    public SmsMessage()
    {
        Console.WriteLine("sms отправлено");
    }
}