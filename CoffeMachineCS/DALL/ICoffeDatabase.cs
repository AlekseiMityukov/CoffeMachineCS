using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeMachineCS.Entities;

namespace CoffeMachineCS.DALL
{
    internal interface ICoffeDatabase
    {
        internal Product[] GetCurrentProducts();
        Product GetProduct(int id);
    }
}
