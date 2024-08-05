using KataPattern02.Model;

namespace KataPattern02.Notifications;

internal interface INotification
{
    bool Send(MessageModel messageModel);
}