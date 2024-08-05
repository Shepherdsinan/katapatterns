using KataPattern02.Model;

namespace KataPattern02.Notifications;

internal class MailNotification : INotification
{
    public bool Send(MessageModel messageModel)
    {
        Console.WriteLine("Mail: " + messageModel.Message);
        return false;
    }
}