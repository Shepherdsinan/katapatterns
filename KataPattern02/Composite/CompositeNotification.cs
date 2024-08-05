using KataPattern02.Model;
using KataPattern02.Notifications;

namespace KataPattern02.Composite;

internal class CompositeNotification(IList<INotification> notifications) : INotification
{
    public bool Send(MessageModel messageModel)
    {
        foreach (var notifiy in notifications)
        {
            notifiy.Send(messageModel);
        }

        return true;
    }
}