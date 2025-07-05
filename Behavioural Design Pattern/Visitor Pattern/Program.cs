using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //var notificationSender1 = new InvoiceNotificationSender();
            //notificationSender1.SetUpEmail();
            //notificationSender1.SetUpText();
            //notificationSender1.Send("Invoice");

            //var notificationSender2 = new MarketingNotificationSender();
            //notificationSender2.SetUpEmail();
            //notificationSender2.SetUpText();
            //notificationSender2.Send("Marketing");

            EmailVisitor emailVisitor = new EmailVisitor();
            TextVisitor textVisitor = new TextVisitor();
            WebSocketVisitor webSocket = new WebSocketVisitor();

            var notificationSender1 = new InvoiceNotificationSender();
            notificationSender1.Accept(emailVisitor);
            notificationSender1.Accept(textVisitor);
            notificationSender1.Send("Invoice");

            Console.WriteLine("");

            var notificationSender2 = new MarketingNotificationSender();
            notificationSender2.Accept(emailVisitor);
            notificationSender2.Accept(textVisitor);
            notificationSender2.Accept(webSocket);
            notificationSender2.Send("Marketing");
        }
    }
}
