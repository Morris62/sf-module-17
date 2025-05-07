namespace FactoryMethod;

public class EmailMessage : Message
{
    public EmailMessage()
    {
        Console.WriteLine("email отправлен");
    }
}