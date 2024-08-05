namespace DesignPatternKata20240805.Notifications;

public interface INotification
{
    bool Send(string message);
}