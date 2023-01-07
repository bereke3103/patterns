using ConsoleApp1.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Child
{
    class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if(receiver.BankTransfer == true)
            {
                Console.WriteLine("Выполняем банковский перевод");
            } else if (Successor !=null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}
