using KataPattern02.Model;

namespace KataPattern02.Notifications;

internal class ErrorNotification : INotification
{
    public bool Send(MessageModel messageModel)
    {
        Console.WriteLine("Error: Not send" + messageModel.Message);
        return true;
    }
}