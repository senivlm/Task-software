using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_software
{
    class DairyProduct:Product
    {        
        public DateTime DateOfManufacture { get; set; }
        public DateTime OutOFDate { get; set; }
        public DairyProduct(DateTime dateOfManufacture, DateTime outOFDate, string name, decimal price, double weight) : base(name, price, weight)
        {
            OutOFDate = outOFDate;
            DateOfManufacture = dateOfManufacture;
        }
        public override void ChangePrice(double percentage)
        {
            const double decreasePerDay = 1.2;

            var daysFromNowToOUtOFDate = OutOFDate - DateTime.Now;
            percentage -= daysFromNowToOUtOFDate.TotalDays * decreasePerDay;

            base.ChangePrice(percentage);   
        }
        public override string ToString()
        {
            return base.ToString()+$"DateOfManufacture :{DateOfManufacture};\n" +
                $"OutOFDate :{OutOFDate};\n";
        }
        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            var dairyProduct = obj as DairyProduct;
            if (dairyProduct == null)
                return false;

            return DateOfManufacture == dairyProduct.DateOfManufacture && OutOFDate == dairyProduct.OutOFDate;
        }
    }
}
