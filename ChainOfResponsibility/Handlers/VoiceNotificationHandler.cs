namespace ChainOfResponsibility.Handlers;

public class VoiceNotificationHandler : NotificationHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.VoiceNotification)
        {
            Console.WriteLine("Выполнено уведомление по телефону");
        }
        else
        {
            Successor?.Handle(receiver);
        }
    }
}