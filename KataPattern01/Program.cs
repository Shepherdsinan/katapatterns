using DesignPatternKata20240805.Facade;
using DesignPatternKata20240805.Factory;

string message = "Kafka error";

new NotificationFacade(new NotificationFactory()).SendMessage(message);