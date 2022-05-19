using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_software
{
    static class Check
    {
        public static void Show(params Buy[] buys)
        {
            foreach (var buy in buys)
            {
                if (!IsValid(buy))
                    continue;

                ShowProduct(buy);
            }
            
        }
        private static void ShowProduct(Buy buy)
        {
            Console.WriteLine($"{buy}");
        }
        private static bool IsValid(Buy buy)
        {
            var result = true;
            if (buy == null|| buy.Product == null)
                return false;

            return result;
        }
    }
}
