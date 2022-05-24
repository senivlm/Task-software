using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_software
{
    static class Check
    {
        public static void Show(params Buy[] buys)
        {
            foreach (var buy in buys)
            {
                if (!IsValid(buy))
                    //Треба без continue
                    continue;

                ShowProduct(buy);
            }
            
        }
        private static void ShowProduct(Buy buy)
        {
            Console.WriteLine($"Name: {buy.Product.Name}\n" +
               $"Price: {buy.Product.Price}\n" +
               $"Weight: {buy.Product.Weight}\n");

            Console.WriteLine($"Product count: {buy.ProductCount}\n" +
                $"Total price: {buy.TotalPrice}\n" +
                $"Total weight: {buy.TotalWeight}");
        }
        // хороша ідея
        private static bool IsValid(Buy buy)
        {
            var result = true;
            if (buy == null|| buy.Product == null)
                return false;

            return result;
        }
    }
}
