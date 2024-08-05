using DesignPatternKata20240805.Composite;

namespace DesignPatternKata20240805.Factory;

internal interface INotificationFactory
{
    CompositeNotification GetNotifications();
}