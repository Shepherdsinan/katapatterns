using DesignPatternKata20240805.Notifications;

namespace DesignPatternKata20240805.Decorator;

internal class MultipleNotificationDecorator(INotification decoratedNotification, int count) : INotification
{
    public bool Send(string message)
    {
        for (int i = 0; i < count; i++)
        {
            decoratedNotification.Send(message);
        }

        return true;
    }
}