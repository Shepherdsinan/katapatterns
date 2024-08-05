namespace DesignPatternKata20240805.Notifications;

public class PushNotification : INotification
{
    public bool Send(string message)
    {
        Console.WriteLine("Push :" + message);
        return true;
    }
}