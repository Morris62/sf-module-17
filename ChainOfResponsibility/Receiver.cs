namespace ChainOfResponsibility;

public class Receiver(bool emailNotification, bool smsNotification, bool voiceNotification)
{
    public bool EmailNotification { get; private set; } = emailNotification;
    public bool SmsNotification { get; private set; } = smsNotification;
    public bool VoiceNotification { get; private set; } = voiceNotification;
}