using ConsoleApp1.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Child
{
    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
            {
                Console.WriteLine("Выполняем перевод через Paypal");
            } else if (Successor != null )
            {
                Successor.Handle(receiver);
            }
        }
    }
}
