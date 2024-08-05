namespace DesignPatternKata20240805.Notifications;

public class MailNotification : INotification
{
    public bool Send(string message)
    {
        Console.WriteLine("Mail :" + message);
        return true;
    }
}