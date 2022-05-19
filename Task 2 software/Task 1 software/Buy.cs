using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_software
{
    class Buy
    {
        public Product Product { get; set; }
        public int ProductCount { get; set; }
        public decimal TotalPrice { get; set; }
        public double TotalWeight { get; set; }

        public Buy(Product product,int productCount)
        {
            if (product == null || productCount <= 0)
                return;

            Product = product;
            ProductCount = productCount;
            TotalPrice += product.Price* productCount;
            TotalWeight += product.Weight* productCount;
        }
        public override string ToString()
        {
            return $" Product: \n{Product} \n " +
                $"ProductCount : {ProductCount}" +
                $"TotalPrice : {TotalPrice}" +
                $"TotalWeight : {TotalWeight}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var buy = obj as Buy;
            if (buy == null)
                return false;

            if (!Product.Equals(buy.Product))
                return false;

            return ProductCount == buy.ProductCount && TotalPrice == buy.TotalPrice && TotalWeight == buy.TotalWeight;

        }
    }
}
