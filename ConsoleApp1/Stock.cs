using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Stock : IObservable
    {
        List<IObserver> observers;
        StockInfo stockInfo;

        public Stock()
        {
            observers= new List<IObserver>();
            stockInfo= new StockInfo();
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(stockInfo);
            }
        }

        public void Market()
        {
            foreach (IObserver observer in observers)
            {
                Random rnd = new Random();
                stockInfo.USD = rnd.Next(20, 40);
                stockInfo.Euro = rnd.Next(30, 50);
            }
        }
    }
}
