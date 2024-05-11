using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeMachineCS.Entities;

namespace CoffeMachineCS.DALL
{
    internal class CoffeDatabase: ICoffeDatabase
    {
        private Product[] _currentProducts = new Product[]
            {
                new Product() {Id = 1, Name = "Латте", Price = 150},
                new Product() {Id = 2, Name = "Капучино", Price = 200},
                new Product() {Id = 3, Name = "Экспрессо", Price = 250},
            };
        
        public Product[] GetCurrentProducts() 
        {
            return _currentProducts;
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id) 
        {
            return _currentProducts.FirstOrDefault(x => x.Id == id);
        }

    }
}
