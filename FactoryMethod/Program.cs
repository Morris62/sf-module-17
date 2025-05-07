using FactoryMethod;

var messageText = "Ваш номер заказа - 123123";

MessageSender sender = new SmsMessageSender("+79879879876");
sender.Send(messageText);

sender = new EmailMessageSender("ivanovii@yandex.ru");
sender.Send(messageText);