using System;

namespace Visitor_Pattern
{
    interface IVisitor
    {
        void Visit(INotificationSender notificationSender);
    }

    internal class EmailVisitor : IVisitor
    {
        public void Visit(INotificationSender notificationSender)
        {
            Console.WriteLine("Setup Email");
        }
    }

    internal class TextVisitor : IVisitor
    {
        public void Visit(INotificationSender notificationSender)
        {
            Console.WriteLine("Setup Text");
        }
    }

    internal class WebSocketVisitor : IVisitor
    {
        public void Visit(INotificationSender notificationSender)
        {
            Console.WriteLine("Setup Web Socket Vistor");
        }
    }
}