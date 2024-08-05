using KataPattern02.ChainOfResponsibility;
using KataPattern02.Enum;
using KataPattern02.Notifications;

namespace KataPattern02.Factory;

internal class NotificationFactory : INotificationFactory
{
    private readonly IDictionary<MessageType,INotification> notificationDictionary;

    public NotificationFactory()
    {
        notificationDictionary = new Dictionary<MessageType, INotification>();
        notificationDictionary.Add(MessageType.Mail, new ChainNotificationDecorator(new MailNotification(), new ChainNotificationDecorator(new SmsNotification(), new ChainNotificationDecorator(new PushNotification(), new ErrorNotification()))));
        notificationDictionary.Add(MessageType.SMS, new ChainNotificationDecorator(new SmsNotification(), new ChainNotificationDecorator(new MailNotification(), new ChainNotificationDecorator(new PushNotification(), new ErrorNotification()))));
        notificationDictionary.Add(MessageType.PUSH, new ChainNotificationDecorator(new PushNotification(), new ChainNotificationDecorator(new SmsNotification(), new ChainNotificationDecorator(new MailNotification(), new ErrorNotification()))));
    }

    public IDictionary<MessageType, INotification> GetNotifications()
    {
        return notificationDictionary;
    }
}