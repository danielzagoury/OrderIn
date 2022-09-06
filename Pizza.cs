using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OrderIn
{
    [Serializable]
    public class Pizza : Main_course
    {
       protected string Type_of_dough;

        public Pizza(string dough, string if_veg, string size)
        {
            _foodName = "Pizza";
            _price = 40;
            Type_of_dough = dough;
            _Type = if_veg;
            _size = size;
        }

        public override string print()
        {
            string print_pizza= Type_of_dough + " ";
            if (_Type == "yes")
                print_pizza += " (vegan) " + _size;
            if (_Type == "no")
                print_pizza += _size;
            return print_pizza;

        }

    }
}
