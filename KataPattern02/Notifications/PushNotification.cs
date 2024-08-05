using KataPattern02.Model;

namespace KataPattern02.Notifications;

internal class PushNotification : INotification
{
    public bool Send(MessageModel message)
    {
        Console.WriteLine("Push: " + message.Message);
        return false;
    }
}