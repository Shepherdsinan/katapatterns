using KataPattern02.Enum;

namespace KataPattern02.Facade;

internal interface INotificationFacade
{
    void SendMessage(MessageType type, string message);
}