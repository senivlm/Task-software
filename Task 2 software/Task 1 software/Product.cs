using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_software
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
        public virtual void ChangePrice(double percentage)
        {
            Price += Price * (decimal)(percentage / 100);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var product = obj as Product;
            if (product==null)
                return false;


            return Name == product.Name 
                || Price == product.Price
                || Weight == product.Weight;
        }
        public override string ToString()
        {
            return $"Name : {Name}; Price : {Price}; Weight : {Weight}";
        }
    }
}
