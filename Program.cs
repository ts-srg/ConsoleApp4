using System;

// Интерфейс для работы с Telegram API
public interface ITelegramAPIClient
{ 
    void SendMessage(int chatId, string text);
}

// Интерфейс для обработки входящих сообщений
public interface IMessageHandler
{
    void HandleMessage(string message);
}

// Класс реализующий логику работы бота
public abstract class TelegramBot : ITelegramAPIClient, IMessageHandler
{
    public virtual void SendMessage(int chatId, string text)
    {
        // Реализация отправки сообщения через Telegram API
    }

    public virtual void HandleMessage(string message)
    {
        // Общая реализация обработки входящих сообщений
    }
}

// Реализация бота
public class MyTelegramBot : TelegramBot
{
    public override void SendMessage(int chatId, string text)
    {
        // Конкретная реализация отправки сообщения через Telegram API
    }

    public override void HandleMessage(string message)
    {
        // Конкретная реализация обработки входящих сообщений
    }
}

// Главный класс программы
class Program
{
    static void Main()
    {
        var bot = new MyTelegramBot();
        // Основная логика бота
    }
}

/* 
Комментарии:
S - Single Responsibility Principle (Принцип единственной обязанности)
ITelegramAPIClient отвечает только за работу с Telegram API.
IMessageHandler отвечает только за обработку входящих сообщений.
O - Open/Closed Principle (Принцип открытости/закрытости)
Классы TelegramBot и MyTelegramBot закрыты для изменений в своей реализации, но открыты для расширения новыми классами.
L - Liskov Substitution Principle (Принцип подстановки Лисков)
MyTelegramBot может использоваться вместо TelegramBot без изменения поведения бота.
I - Interface Segregation Principle (Принцип разделения интерфейсов)
Интерфейсы ITelegramAPIClient и IMessageHandler разделяют методы на более мелкие компоненты, что позволяет классам реализовывать только необходимую функциональность.
D - Dependency Inversion Principle (Принцип инверсии зависимостей)
Классы зависят от абстракций (интерфейсов ITelegramAPIClient и IMessageHandler), а не от конкретных реализаций, что обеспечивает гибкость и упрощает замену компонентов.
*/
