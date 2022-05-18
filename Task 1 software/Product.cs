using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_software
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }

        public Product():this("Cabbage",100,150)
        {

        }
        public Product(string name,decimal price,double weight)
        {
            if (string.IsNullOrWhiteSpace(name) || price <= 0 || weight <= 0)
                return;

            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
