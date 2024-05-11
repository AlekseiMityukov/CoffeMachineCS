using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CoffeMachineCS.DALL;
using CoffeMachineCS.Entities;

namespace CoffeMachineCS.BILL
{
    internal class CoffeManager
    {
        private CoffeDatabase _database;

        public CoffeManager(CoffeDatabase database)
        {
            _database = database;
        }

        internal Product[] GetAssortiment()
        {
            return _database.GetCurrentProducts();
        }

        internal Product SelectProduct(int id) 
        { 
            var item = _database.GetProductById(id);
            return  item;
        }

        internal bool BuyProduct(int id, decimal money) 
        {
            var item = _database.GetProductById(id);  
            
            return money >= item.Price;
        }

    }
}
