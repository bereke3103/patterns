using ConsoleApp1.Child;
using ConsoleApp1.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(false, true, true);

            PaymentHandler bank = new BankPaymentHandler();
            PaymentHandler money = new MoneyPaymentHandler();
            PaymentHandler paypal = new PayPalPaymentHandler();

            bank.Successor = paypal;
            paypal.Successor = money;

            bank.Handle(receiver);
            Console.Read();
        }
    }
}
