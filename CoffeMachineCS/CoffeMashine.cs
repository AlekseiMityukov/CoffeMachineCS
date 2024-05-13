using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CoffeMachineCS.BILL;
using CoffeMachineCS.DALL;
using CoffeMachineCS.Entities;
using CoffeMachineCS.PL;

namespace CoffeMachineCS
{
    internal class CoffeMashine
    {
        private ICoffeDatabase _database;
        private CoffeManager _manager;
        private CoffeConsole _console;

        public CoffeMashine()
        {
            _database = new CoffeDatabase();
            _manager = new CoffeManager((CoffeDatabase)_database);
            _console = new CoffeConsole();
        }

        internal void Run()
        {
            _console.payToCoffe += UsersMoney;
            _console.selectCoffe += ChoiceCoffe;
            _console.text += Text;

            var items = _manager.GetAssortiment();
            _console.ProductShow(items);
            var product = _manager.SelectProduct(_console.SelectCoffe(0));
            _console.Payment(product.Name);
            decimal usersMoney = _console.PayToCoffee(0);


            while (usersMoney < product.Price)
            {
                decimal curentMoney = product.Price - usersMoney;
                _console.LeftPay(curentMoney);
                usersMoney += _console.PayToCoffee(0);
            }
            if (usersMoney == product.Price)
            {
                _console.Final(product.Name);
            }
            else if (usersMoney > product.Price)
            {
                usersMoney = usersMoney - product.Price;
                _console.ReturnMoney(usersMoney);
                _console.Final(product.Name);
            }
        }


        internal static decimal UsersMoney(decimal userMoney)
        {
            return decimal.Parse(Console.ReadLine());
        }

        internal static int ChoiceCoffe(int idCoffe)
        {
            return int.Parse(Console.ReadLine());
        }

        internal static void Text(string text) 
        {
            Console.WriteLine(text);
        }


    }
}
