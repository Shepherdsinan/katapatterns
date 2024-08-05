using DesignPatternKata20240805.Notifications;

namespace DesignPatternKata20240805.Composite;

internal class CompositeNotification(IList<INotification> notifications) : INotification
{
    private readonly IList<INotification> notifications = notifications;
    
    public bool Send(string message)
    {
        foreach (var notification in notifications)
        {
            notification.Send(message);
        }

        return true;
    }
}