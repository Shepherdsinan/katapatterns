using KataPattern02.Model;
using KataPattern02.Notifications;

namespace KataPattern02.Decorator;

internal class ReverseMessageNotificationDecorator(INotification decoratedNotification) : INotification
{
    public bool Send(MessageModel messageModel)
    {
        string reversedMessage = ReverseMessage(messageModel.Message);
        messageModel.Message = reversedMessage;
        return decoratedNotification.Send(messageModel);
    }
    
    private string ReverseMessage(string message)
    {
        var charArray = message.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}