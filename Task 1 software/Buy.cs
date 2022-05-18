using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_software
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
    }
}
