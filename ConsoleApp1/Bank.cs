using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bank : IObserver
    {
        public string Name { get; set; }

        IObservable stock;

        public Bank(string name, IObservable obs)
        {
            Name = name;
            stock = obs;
            stock.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            StockInfo stockInfo = (StockInfo)ob;
            if (stockInfo.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, stockInfo.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, stockInfo.Euro);
        }
    }
}
