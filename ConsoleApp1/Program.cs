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
            Stock stock = new Stock();
            Bank bank = new Bank("Юнит банк", stock);
            Broker broker = new Broker("Брокер", stock);

            //stock.Market();

            ////broker.StopTrade();

            //stock.Market();

            bank.Update(bank);

            Console.ReadLine();
        }
    }
}
