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
    public class Orders
    {
        public static int order_counter = 1;
        public List<Order> _orderlist;
        public Orders()
        {
            _orderlist = new List<Order>();
        }
    }

}
