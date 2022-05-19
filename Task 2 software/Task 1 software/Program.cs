using System;

namespace Task_2_software
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Pizza", 150, 500);
            var buy = new Buy(product, 5);
            Check.Show(buy);
            var storage = new Storage();
            storage.ShowInfo();

            var meats = storage.GetMeats();
            storage.ChangePrices(25);
            storage.ShowInfo();

            var meat = new Meat(Category.HeigerSort1, TypeOfMeet.pork, "Meat", 1202, 1581);
            var dairyProduct = new DairyProduct(DateTime.Now.AddDays(-50), DateTime.Now, "DairyProduct", 1203, 1582);

            var isProduct = product.Equals(storage[0]);
            var isMeat = meat.Equals(storage[1]);
            var isDairyProduct = dairyProduct.Equals(storage[2]);

        }
    }
}
