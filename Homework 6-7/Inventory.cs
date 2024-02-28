using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_6_7
{
    internal class Inventory
    {
        private List<Product> products;

        public Inventory() 
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal GetPrice()
        {
            decimal price = 0;

            foreach(var product in products)
            {
                price += product.Price * product.Quantity;
            }
            return price;
        }
    }
}
