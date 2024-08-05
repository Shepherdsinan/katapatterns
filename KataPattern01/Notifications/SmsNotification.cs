namespace DesignPatternKata20240805.Notifications;

public class SmsNotification : INotification
{
    public bool Send(string message)
    {
        Console.WriteLine("Sms :" + message);
        return true;
    }
}