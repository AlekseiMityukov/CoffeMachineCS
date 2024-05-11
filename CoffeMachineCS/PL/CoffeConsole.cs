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
        internal int Start(Product[] items)
        {
            Console.WriteLine("Добро пожаловать!");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id}){item.Name}: {item.Price}");
            }
            Console.WriteLine("Выберите коффе");
            return int.Parse(Console.ReadLine());
        }

        internal decimal Enter(string name)
        {
            Console.WriteLine($"{name} почти готого, осталось только оплатить...");
            Console.WriteLine("Внесите сумму");
            return decimal.Parse(Console.ReadLine());
        }

        internal decimal Buy(decimal current)
        {
            Console.WriteLine($"Осталось внести {current} руб.");
            return decimal.Parse(Console.ReadLine());
        }

        internal void FinalMore(decimal money) 
        {
            Console.WriteLine($"Заберите сдачу {money} руб.");

        }

        internal void Final(string name)
        {
            Console.WriteLine($"Приятного дня! Заберите {name}.");
        }
    }
}
