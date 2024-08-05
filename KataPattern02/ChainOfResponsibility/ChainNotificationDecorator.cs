using KataPattern02.Model;
using KataPattern02.Notifications;

namespace KataPattern02.ChainOfResponsibility;

internal class ChainNotificationDecorator(INotification decoratedNotification, INotification nextNotification) : INotification
{
    public bool Send(MessageModel messageModel)
    {
        var result = decoratedNotification.Send(messageModel);

        if (!result)
        {
            Console.WriteLine(messageModel.Type + "Sending failed");
            return nextNotification.Send(messageModel);
        }

        return result;
    }
}