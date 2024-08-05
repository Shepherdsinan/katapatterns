using DesignPatternKata20240805.Composite;
using DesignPatternKata20240805.Decorator;
using DesignPatternKata20240805.Notifications;

namespace DesignPatternKata20240805.Factory;

internal class NotificationFactory(IList<INotification> notificationList) : INotificationFactory
{
    private readonly IList<INotification> notificationList = notificationList;

    public NotificationFactory() : this(new List<INotification>())
    {
        notificationList.Add(new MultipleNotificationDecorator(new MailNotification(), 2));
        notificationList.Add(new MultipleNotificationDecorator(new ReverseMessageNotificationDecorator(new SmsNotification()), 3));
        notificationList.Add(new MultipleNotificationDecorator(new SmsNotification(), 4));
        notificationList.Add(new MultipleNotificationDecorator(new PushNotification(), 2));
    }

    public CompositeNotification GetNotifications()
    {
        return new CompositeNotification(notificationList);
    }
}