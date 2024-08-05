using KataPattern02.Model;

namespace KataPattern02.Notifications;

internal class SmsNotification : INotification
{
    public bool Send(MessageModel message)
    {
        Console.WriteLine("SMS: " + message.Message);
        return false;
    }
}