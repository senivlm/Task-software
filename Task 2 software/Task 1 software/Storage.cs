using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_software
{
    class Storage
    {
        public List<Product> Products { get; set; }
        public Storage()
        {
            Products = new List<Product>() {
                new Product("Pizza",120,158),
                new Meat(Category.HeigerSort1,TypeOfMeet.pork,"Meat",1202,1581),
                new DairyProduct(DateTime.Now.AddDays(-50),DateTime.Now,"DairyProduct",1203,1582)
            };
        }
        public Product this[int index]
        {
            get => Products[index];
            set => Products[index] = value;
        }
        public Storage(params Product[] products)
        {
            Products.AddRange(products);
        }
        public void ShowInfo()
        {
            foreach (var product in Products)
            {
                Console.WriteLine($"{product}");
            }        
        }
        public IEnumerable<Meat> GetMeats()
        {
            var meats = Products.OfType<Meat>();
            return meats;
        }
        public void ChangePrices(double percentage)
        {
            Products.ForEach(x=>x.ChangePrice(percentage));
        }
   

    }
}
