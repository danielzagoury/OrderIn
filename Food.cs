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
    public abstract class Food
    {
        protected string _foodName { get; set; }
        protected double _price { get; set; }
        protected string _Type; 

        public abstract string print();
    }
    
}


