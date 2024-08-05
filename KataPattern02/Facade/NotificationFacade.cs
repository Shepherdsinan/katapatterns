using KataPattern02.Enum;
using KataPattern02.Factory;
using KataPattern02.Model;

namespace KataPattern02.Facade;

internal class NotificationFacade(INotificationFactory notificationFactory) : INotificationFacade
{
    public void SendMessage(MessageType type, string message)
    {
        var model = new MessageModel
        {
            Type = type,
            Message = message
        };
        notificationFactory.GetNotifications()[type].Send(model);
    }
}