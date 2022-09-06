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
    public partial class New_oredr : Form
    {

        Orders _Orders;
        Order _Neword;

        public New_oredr(Orders OrderList)
        {
            InitializeComponent();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            combo_dessert.Hide();
            combo_burger.Hide();
            combo_pizza.Hide();
            Add_button.Hide();
            comboBox_veg.Hide();
            weight_box.Hide();
            combo_cook.Hide();
            combo_pizza_size.Hide();
            combo_pizza.Items.Insert(0, "Pizza with thin crust");
            combo_pizza.Items.Insert(1, "Pizza with Regular crust");
            combo_pizza.Items.Insert(2, "Pizza with Thick crust");
            _Orders = OrderList;
            _Neword = new Order();
            pictureBox2.Visible = false;
        }

        public void AddHamburger()
        {
            Hamburger adding = new Hamburger(comboBox_veg.Text.ToString(), weight_box.Text.ToString(), combo_cook.Text.ToString(), combo_burger.Text.ToString());
            _Neword._food.Add(adding);
        }

        public void AddPizza()
        {
            Pizza adding = new Pizza(combo_pizza.Text.ToString(), comboBox_veg.Text.ToString(), combo_pizza_size.Text.ToString());
            _Neword._food.Add(adding);
        }
        public void AddDessert()
        {
            Dessert adding = new Dessert(combo_dessert.Text.ToString(), comboBox_veg.Text.ToString());
            _Neword._food.Add(adding);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBtn();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBtn();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBtn();
        }

        private void Selected_food_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox_veg.Show();
                comboBox_veg.Text = "is vegan?";
                weight_box.Text = "weight";
                name_label1.Text = "Hamburger";
                combo_cook.Text = "cooking level";
                combo_burger.Text = "Type of hamburger";
                combo_burger.Show();
                combo_dessert.Hide();
                combo_pizza.Hide();
                weight_box.Show();
                combo_cook.Show();
                combo_pizza_size.Hide();
                pictureBox2.Image = global::menu.Properties.Resources.hamburger;
                pictureBox2.InitialImage = global::menu.Properties.Resources.hamburger;
                pictureBox2.BackColor = System.Drawing.Color.Transparent;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBox2.Visible = true;

            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comboBox_veg.Text = "is vegan?";
                combo_pizza.Text = "type of pizza";
                name_label1.Text = "Pizza";
                combo_pizza_size.Text="size";

                combo_burger.Hide();
                combo_dessert.Hide();
                combo_pizza_size.Show();
                comboBox_veg.Show();
                combo_pizza.Show();
                weight_box.Hide();
                combo_cook.Hide();
                pictureBox2.Image = global::menu.Properties.Resources.pizza;
                pictureBox2.InitialImage = global::menu.Properties.Resources.pizza;
                pictureBox2.BackColor = System.Drawing.Color.Transparent;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBox2.Visible = true;

            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                comboBox_veg.Show();
                comboBox_veg.Text = "is vegan?";
                combo_dessert.Text = "type of dessert";
                name_label1.Text = "Dessert";
                combo_burger.Hide();
                combo_dessert.Show();
                combo_pizza.Hide();
                weight_box.Hide();
                combo_cook.Hide();
                combo_pizza_size.Hide();
                pictureBox2.Image = global::menu.Properties.Resources.dessert;
                pictureBox2.InitialImage = global::menu.Properties.Resources.dessert;
                pictureBox2.BackColor = System.Drawing.Color.Transparent;
                pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBox2.Visible = true;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void New_orede_Load(object sender, EventArgs e)
        {

        }

        private void text_order_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)// finish button
        {
            if (MessageBox.Show("Orders are final and cannot be changed, would you like to continue?", "Finishing Order", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _Neword.order_num = Orders.order_counter;
                _Orders._orderlist.Add(_Neword);
                Orders.order_counter++;
                _Neword.OrderTime = dateTimePicker1.Value.ToShortDateString();
                this.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            ShowBtn();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ShowBtn();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (combo_burger.Text != "Type of hamburger" && radioButton1.Checked == true)
            {
               
               order_list.Items.Add(combo_burger.Text+" "+ weight_box.Text+" "+ combo_cook.Text+ "\r\n");
                AddHamburger();
               combo_burger.Text = "Type of hamburger";
            }

            if (combo_dessert.Text != "type of dessert" && radioButton3.Checked == true)
            {
                if (comboBox_veg.Text == "yes")
                    order_list.Items.Add(combo_dessert.Text + " (vegan)\r\n");
                if (comboBox_veg.Text == "no")
                    order_list.Items.Add(combo_dessert.Text + "\r\n");
                AddDessert();
                combo_dessert.Text = "type of dessert";
            }
            if (combo_pizza.Text != "type of pizza" && radioButton2.Checked == true)
            {
                if (comboBox_veg.Text == "yes")
                    order_list.Items.Add(combo_pizza.Text + " (vegan)"+" "+ combo_pizza_size.Text+"\r\n");
                if (comboBox_veg.Text == "no")
                    order_list.Items.Add(combo_pizza.Text + " " + combo_pizza_size.Text + "\r\n");
                AddPizza();
                combo_pizza.Text = "type of pizza";
            }
            Add_button.Hide();
            comboBox_veg.Hide();
            comboBox_veg.Text = "is vegan?";
            combo_dessert.Hide();
            combo_burger.Hide();
            combo_pizza.Hide();
            weight_box.Hide();
            combo_cook.Hide();
            combo_pizza_size.Hide();
            name_label1.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            pictureBox2.Visible = false;

        }

        private void comboBox_veg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (comboBox_veg.Text == "yes")
                {
                    combo_burger.Items.Clear();
                    combo_burger.Items.Insert(0, "Mushroom");
                    combo_burger.Items.Insert(1, "Vegi-mix");
                }
                if (comboBox_veg.Text == "no")
                {
                    combo_burger.Items.Clear();
                    combo_burger.Items.Insert(0, "Beef");
                    combo_burger.Items.Insert(1, "Lamb");
                }
            }
            ShowBtn();
        }

        private void weight_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBtn();
        }

        private void combo_pizza_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBtn();
        }
        private void combo_cook_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBtn();
        }
        private void ShowBtn()
        {
            if (radioButton1.Checked == true && comboBox_veg.Text != "is vegan?"
                && weight_box.Text != "weight"
            && combo_cook.Text != "cooking level"
            && combo_burger.Text != "Type of hamburger") 
            {
                Add_button.Show();
            }

            if(radioButton2.Checked == true && comboBox_veg.Text != "is vegan?"&&
            combo_pizza.Text != "type of pizza" &&
            combo_pizza_size.Text != "size" )
            {
                Add_button.Show();
            }

            if (radioButton3.Checked == true && comboBox_veg.Text != "is vegan?"&&
            combo_dessert.Text != "type of dessert")
            {
                Add_button.Show();
            }

        }



        private void delete_button_Click(object sender, EventArgs e)
        {
            int todelete = order_list.SelectedIndex;
            _Neword._food.RemoveAt(todelete);
            order_list.Items.RemoveAt(todelete);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void order_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
