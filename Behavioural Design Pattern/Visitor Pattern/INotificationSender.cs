using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    interface INotificationSender
    {
        //void SetUpEmail();
        //void SetUpText();
        void Send(string message);

        void Accept(IVisitor vistor);
    }

    internal class InvoiceNotificationSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Notification Sent: {message}");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        //public void SetUpEmail()
        //{
        //    Console.WriteLine("Setup Email");
        //}

        //public void SetUpText()
        //{
        //    Console.WriteLine("Setup Text");
        //}
    }

    internal class MarketingNotificationSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Notification Sent: {message}");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
