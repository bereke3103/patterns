using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Broker : IObserver
    {
        public string Name { get; set; }

        IObservable stock;

        public Broker(string name, IObservable obs)
        {
            Name = name;
            stock = obs;
            stock.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            StockInfo stock = (StockInfo) ob;
            if (stock.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", Name, stock.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", Name, stock.USD);
        }

        public void StopTrade()
        {
            stock.RemoveObserver(this); 
            stock = null;
        }
    }
}
