using System;

namespace Task_1_software
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Pizza",150,500);
            var buy = new Buy(product,5);
            Check.Show(buy);
        }
    }
}
