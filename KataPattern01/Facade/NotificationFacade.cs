using DesignPatternKata20240805.Factory;

namespace DesignPatternKata20240805.Facade;

internal class NotificationFacade(INotificationFactory notificationFactory) : INotificationFacade
{
    public void SendMessage(string message)
    {
        notificationFactory.GetNotifications().Send(message);
    }
}