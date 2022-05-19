using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_software
{
    class Meat : Product
    {
        public Category Category { get; set; }
        public TypeOfMeet TypeOfMeet { get; set; }
        public Meat(Category category, TypeOfMeet typeOfMeet, string name,decimal price,double weight) : base(name, price, weight)
        {
            Category = category;
            TypeOfMeet = typeOfMeet;
        }
        public override void ChangePrice(double percentage)
        {
            percentage += Category switch
            {
                Category.HeigerSort1 => 10,
                Category.HeigerSort2 => 20,            
            };
            if (percentage < -100)
                return;
            
            base.ChangePrice(percentage);
        }
        public override string ToString()
        {
            return base.ToString()+
                $"Category : {Category}" +
                $"TypeOfMeet : {TypeOfMeet}";
        }
        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            var dairyProduct = obj as Meat;
            if (dairyProduct == null)
                return false;

            return Category == dairyProduct.Category && TypeOfMeet == dairyProduct.TypeOfMeet;
        }
    }
    public enum Category
    {
        HeigerSort1,
        HeigerSort2,
    }
    public enum TypeOfMeet
    {
        mutton,
        veal,
        pork,
        chicken
    }
}
