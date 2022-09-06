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
    public class Dessert : Food
    {
        public Dessert(string dess_type,string if_veg)
        {
            _foodName = dess_type;
            _Type = if_veg;
            _price = 35;
        }
        public override string print()
        {
            string print_dessert;
            print_dessert = _foodName;
            if (_Type == "yes")
                print_dessert += " (vegan) ";
            return print_dessert;
        }
    }
}
