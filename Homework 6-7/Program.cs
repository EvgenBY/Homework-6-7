using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем продукты
            Product product1 = new Product(1, "Product 1", 10.99m, 5);
            Product product2 = new Product(2, "Product 2", 5.99m, 10);

            // Создаем инвентарь
            Inventory inventory = new Inventory();

            // Добавляем продукты в инвентарь
            inventory.AddProduct(product1);
            inventory.AddProduct(product2);

            // Рассчитываем общую стоимость инвентаря
            decimal totalValue = inventory.GetPrice();

            // Выводим результат
            Console.WriteLine($"Total Inventory Value: {totalValue}");
        }
    }
}
