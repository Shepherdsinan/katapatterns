using DesignPatternKata20240805.Notifications;

namespace DesignPatternKata20240805.Decorator;

internal class ReverseMessageNotificationDecorator(INotification decoratedNotification) : INotification
{
    private readonly INotification decoratedNotification = decoratedNotification;

    public bool Send(string message)
    {
        string reverseMessage = Reverse(message);
        
        return decoratedNotification.Send(reverseMessage);
    }
    
    private string Reverse(string message)
    {
        string str = message;
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reversedStr = new string(charArray);
        return reversedStr;
    }
}