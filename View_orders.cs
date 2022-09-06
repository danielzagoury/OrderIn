using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderIn;


namespace menu
{
    [Serializable]
    public partial class View_orders : Form
    {
        Orders _Orders;
        int view = 1;

        public View_orders(Orders OrderList)
        {
            InitializeComponent();
            _Orders = OrderList;
            for(int i=0;i<_Orders._orderlist.Count;i++)
            {
                listBox2.Items.Add(_Orders._orderlist[i].order_num + "              " + _Orders._orderlist[i].OrderTime + "\r\n");
            }
            if (listBox2.Items.Count == 0)
            {
                delete.Hide();
            }
        }

        private void Orders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void order_num_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view == 1)
            {
                string select = listBox2.SelectedItem.ToString();
                int i = 0, k = 0, order_num = 0;
                while (i < select.Length && select[i] >= '0' && select[i] <= '9')
                {
                    order_num *= 10;
                    order_num += (select[i] - '0');
                    i++;
                }
                for (i = 0; i < _Orders._orderlist.Count; i++)//list of orders
                {
                    if (_Orders._orderlist[i].order_num == order_num)//
                    {
                        listBox1.Items.Clear();
                        for (k = 0; k < _Orders._orderlist[i]._food.Count; k++)
                        {
                            listBox1.Items.Add(_Orders._orderlist[i]._food[k].print());
                        }
                    }
                }
            }
            view = 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void delete_Click(object sender, EventArgs e)
        {
            int todelete = listBox2.SelectedIndex;
            view = 0;
            _Orders._orderlist.RemoveAt(todelete);
            listBox2.Items.RemoveAt(todelete);
            listBox1.Items.Clear();
            if (listBox2.Items.Count == 0)
            {
                delete.Hide();
            }
        }
    }
}
