namespace ChainOfResponsibility.Handlers;

public class EmailNotificationHandler : NotificationHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.EmailNotification)
        {
            Console.WriteLine("Выполнено уведомление по email");
        }
        else
        {
            Successor?.Handle(receiver);
        }
    }
}