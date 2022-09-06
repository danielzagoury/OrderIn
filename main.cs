using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using OrderIn;

namespace menu
{
    [Serializable]
    public partial class main : Form
    {
        Orders OrderList = new Orders();
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.right_panel.BringToFront();
            LoadForm(new New_oredr(this.OrderList));
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.right_panel.BringToFront();
            LoadForm(new View_orders(this.OrderList));

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        public void LoadForm(object Form)
        {
            if (this.right_panel.Controls.Count > 0)
            {
                this.right_panel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Right;
            this.right_panel.Controls.Add(f);
            this.right_panel.Tag = f;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void save_Click(object sender, EventArgs e)
        {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog1.Filter = "Order files (*.ord)|*.ord|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    IFormatter formatter = new BinaryFormatter();
                    using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        formatter.Serialize(stream, OrderList);
                    }
                }
        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "Order files (*.ord)|*.ord|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                OrderList = (Orders)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
