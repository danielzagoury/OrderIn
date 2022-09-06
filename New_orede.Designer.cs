
namespace menu
{
    partial class New_oredr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_label1 = new System.Windows.Forms.Label();
            this.combo_dessert = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.combo_burger = new System.Windows.Forms.ComboBox();
            this.combo_pizza = new System.Windows.Forms.ComboBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.finish_order__button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Add_button = new System.Windows.Forms.Button();
            this.comboBox_veg = new System.Windows.Forms.ComboBox();
            this.weight_box = new System.Windows.Forms.ComboBox();
            this.combo_cook = new System.Windows.Forms.ComboBox();
            this.order_list = new System.Windows.Forms.ListBox();
            this.combo_pizza_size = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // name_label1
            // 
            this.name_label1.AutoSize = true;
            this.name_label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label1.Location = new System.Drawing.Point(32, 110);
            this.name_label1.Name = "name_label1";
            this.name_label1.Size = new System.Drawing.Size(0, 19);
            this.name_label1.TabIndex = 1;
            this.name_label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // combo_dessert
            // 
            this.combo_dessert.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_dessert.FormattingEnabled = true;
            this.combo_dessert.Items.AddRange(new object[] {
            "Cakes",
            "Cookies",
            "Frozen"});
            this.combo_dessert.Location = new System.Drawing.Point(35, 161);
            this.combo_dessert.Name = "combo_dessert";
            this.combo_dessert.Size = new System.Drawing.Size(154, 27);
            this.combo_dessert.TabIndex = 8;
            this.combo_dessert.Text = "type of dessert";
            this.combo_dessert.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(35, 70);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 23);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.Text = "Hamburger";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(131, 70);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 23);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "Pizza";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(186, 70);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 23);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.Text = "Dessert";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // combo_burger
            // 
            this.combo_burger.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_burger.ForeColor = System.Drawing.SystemColors.WindowText;
            this.combo_burger.FormattingEnabled = true;
            this.combo_burger.Location = new System.Drawing.Point(34, 161);
            this.combo_burger.Name = "combo_burger";
            this.combo_burger.Size = new System.Drawing.Size(155, 27);
            this.combo_burger.TabIndex = 4;
            this.combo_burger.Text = "Type of hamburger";
            this.combo_burger.Visible = false;
            this.combo_burger.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // combo_pizza
            // 
            this.combo_pizza.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_pizza.FormattingEnabled = true;
            this.combo_pizza.Location = new System.Drawing.Point(36, 161);
            this.combo_pizza.Name = "combo_pizza";
            this.combo_pizza.Size = new System.Drawing.Size(154, 27);
            this.combo_pizza.TabIndex = 6;
            this.combo_pizza.Text = "type of pizza";
            this.combo_pizza.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(489, 398);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 47);
            this.delete_button.TabIndex = 16;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // finish_order__button
            // 
            this.finish_order__button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_order__button.Location = new System.Drawing.Point(673, 398);
            this.finish_order__button.Name = "finish_order__button";
            this.finish_order__button.Size = new System.Drawing.Size(75, 47);
            this.finish_order__button.TabIndex = 17;
            this.finish_order__button.Text = "finish order";
            this.finish_order__button.UseVisualStyleBackColor = true;
            this.finish_order__button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(489, 358);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 23);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.SystemColors.Window;
            this.Add_button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.Location = new System.Drawing.Point(35, 308);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(120, 45);
            this.Add_button.TabIndex = 20;
            this.Add_button.Text = "Add to order";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // comboBox_veg
            // 
            this.comboBox_veg.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_veg.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_veg.FormattingEnabled = true;
            this.comboBox_veg.ItemHeight = 19;
            this.comboBox_veg.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.comboBox_veg.Location = new System.Drawing.Point(35, 134);
            this.comboBox_veg.Name = "comboBox_veg";
            this.comboBox_veg.Size = new System.Drawing.Size(154, 27);
            this.comboBox_veg.TabIndex = 21;
            this.comboBox_veg.Text = "is vegan?";
            this.comboBox_veg.SelectedIndexChanged += new System.EventHandler(this.comboBox_veg_SelectedIndexChanged);
            // 
            // weight_box
            // 
            this.weight_box.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_box.FormattingEnabled = true;
            this.weight_box.Items.AddRange(new object[] {
            "200 gr",
            "300 gr",
            "400 gr "});
            this.weight_box.Location = new System.Drawing.Point(35, 188);
            this.weight_box.Name = "weight_box";
            this.weight_box.Size = new System.Drawing.Size(154, 27);
            this.weight_box.TabIndex = 22;
            this.weight_box.Text = "weight";
            this.weight_box.SelectedIndexChanged += new System.EventHandler(this.weight_box_SelectedIndexChanged);
            // 
            // combo_cook
            // 
            this.combo_cook.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_cook.FormattingEnabled = true;
            this.combo_cook.Items.AddRange(new object[] {
            "R",
            "MR",
            "M",
            "MW",
            "WD"});
            this.combo_cook.Location = new System.Drawing.Point(35, 215);
            this.combo_cook.Name = "combo_cook";
            this.combo_cook.Size = new System.Drawing.Size(154, 27);
            this.combo_cook.TabIndex = 23;
            this.combo_cook.Text = "cooking level";
            this.combo_cook.SelectedIndexChanged += new System.EventHandler(this.combo_cook_SelectedIndexChanged);
            // 
            // order_list
            // 
            this.order_list.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_list.FormattingEnabled = true;
            this.order_list.ItemHeight = 19;
            this.order_list.Location = new System.Drawing.Point(489, 70);
            this.order_list.Name = "order_list";
            this.order_list.Size = new System.Drawing.Size(259, 251);
            this.order_list.TabIndex = 24;
            this.order_list.SelectedIndexChanged += new System.EventHandler(this.order_list_SelectedIndexChanged);
            // 
            // combo_pizza_size
            // 
            this.combo_pizza_size.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_pizza_size.FormattingEnabled = true;
            this.combo_pizza_size.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.combo_pizza_size.Location = new System.Drawing.Point(35, 188);
            this.combo_pizza_size.Name = "combo_pizza_size";
            this.combo_pizza_size.Size = new System.Drawing.Size(154, 27);
            this.combo_pizza_size.TabIndex = 25;
            this.combo_pizza_size.Text = "size";
            this.combo_pizza_size.SelectedIndexChanged += new System.EventHandler(this.combo_pizza_size_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::menu.Properties.Resources.giphy1;
            this.pictureBox1.Location = new System.Drawing.Point(754, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "what do you want to eat? :)\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(250, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 187);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // New_oredr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::menu.Properties.Resources._8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 561);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combo_pizza_size);
            this.Controls.Add(this.order_list);
            this.Controls.Add(this.combo_cook);
            this.Controls.Add(this.weight_box);
            this.Controls.Add(this.comboBox_veg);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.finish_order__button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.combo_dessert);
            this.Controls.Add(this.combo_pizza);
            this.Controls.Add(this.combo_burger);
            this.Controls.Add(this.name_label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New_oredr";
            this.ShowIcon = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.New_orede_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name_label1;
        private System.Windows.Forms.ComboBox combo_dessert;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox combo_pizza;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button finish_order__button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox combo_burger;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.ComboBox comboBox_veg;
        private System.Windows.Forms.ComboBox weight_box;
        private System.Windows.Forms.ComboBox combo_cook;
        private System.Windows.Forms.ListBox order_list;
        private System.Windows.Forms.ComboBox combo_pizza_size;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}