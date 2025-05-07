using ChainOfResponsibility;
using ChainOfResponsibility.Handlers;

var receiver = new Receiver(false, true, true);

var emailNotification = new EmailNotificationHandler();
var smsNotification = new SmsNotificationHandler();
var voiceNotification = new VoiceNotificationHandler();

emailNotification.Successor = smsNotification;
smsNotification.Successor = voiceNotification;

emailNotification.Handle(receiver);