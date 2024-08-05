using KataPattern02.Enum;
using KataPattern02.Notifications;

namespace KataPattern02.Factory;

internal interface INotificationFactory
{
    IDictionary<MessageType,INotification> GetNotifications();
}