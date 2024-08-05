using KataPattern02.Enum;
using KataPattern02.Facade;
using KataPattern02.Factory;

string message = "Kafka system is down";

new NotificationFacade(new NotificationFactory()).SendMessage(MessageType.SMS, message);