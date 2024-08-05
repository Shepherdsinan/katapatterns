using KataPattern02.Model;
using KataPattern02.Notifications;

namespace KataPattern02.Decorator;

internal class MultipleNotificationDecorator(INotification decoratedNotification, int count) : INotification
{
    public bool Send(MessageModel messageModel)
    {
        for (int i = 0; i < count; i++)
        {
            decoratedNotification.Send(messageModel);
        }

        return true;
    }
}