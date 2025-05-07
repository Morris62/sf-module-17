namespace ChainOfResponsibility.Handlers;

public class SmsNotificationHandler : NotificationHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.SmsNotification)
        {
            Console.WriteLine("Выполнено уведомление по sms");
        }
        else
        {
            Successor?.Handle(receiver);
        }
    }
}