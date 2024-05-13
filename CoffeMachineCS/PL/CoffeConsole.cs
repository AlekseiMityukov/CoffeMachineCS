using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeMachineCS.Entities;

namespace CoffeMachineCS.PL
{
    internal class CoffeConsole
    {
        public event Func<decimal, decimal> payToCoffe;
        public event Func<int, int> selectCoffe;
        public event Action<string> text;

        internal void ProductShow(Product[] items)
        {
            Console.WriteLine("Добро пожаловать!");
            foreach (var item in items)
            {
                text?.Invoke($"{item.Id}){item.Name}: {item.Price}");
            }
            text?.Invoke("Выберите коффе");
        }

        internal int SelectCoffe(int coffeId) 
        {
            return selectCoffe(coffeId);
        }

        internal void Payment (string name)
        {
            text?.Invoke($"{name} почти готого, осталось только оплатить...");
            text?.Invoke("Внесите сумму");
        }

        internal decimal PayToCoffee(decimal pay) 
        {
            return payToCoffe(pay);     
        }


        internal void LeftPay(decimal current)
        {
            text?.Invoke($"Осталось внести {current} руб.");
        }

        internal void ReturnMoney(decimal money) 
        {
            text?.Invoke($"Заберите сдачу {money} руб.");

        }

        internal void Final(string name)
        {
            text?.Invoke($"Приятного дня! Заберите {name}.");
        }
    }
}
