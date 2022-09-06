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
    public class Order
    {
        public List<Food> _food;
        public string OrderTime;
        public int order_num;

        public Order()
        {
            _food = new List<Food>();
        }
    }
}