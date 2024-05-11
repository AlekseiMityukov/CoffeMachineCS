using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            int number = _console.Start(_manager.GetAssortiment());
            var product = _manager.SelectProduct(number);
            decimal money = _console.Enter(product.Name);
            while (money < product.Price)
            {
                decimal currentMoney = product.Price - money;
                money += _console.Buy(currentMoney);
            }
            if (money == product.Price)
            {
                _console.Final(product.Name);
            }
            else if (money > product.Price)
            {
                money = money - product.Price;
                _console.FinalMore(money);
                _console.Final(product.Name);
            }
        }

    }
}
