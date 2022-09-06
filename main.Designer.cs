
namespace menu
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.right_panel = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(23, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "New order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "View orders";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(15, 24);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(205, 43);
            this.name.TabIndex = 3;
            this.name.Text = "order manager";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(-1, 522);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::menu.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // right_panel
            // 
            this.right_panel.BackgroundImage = global::menu.Properties.Resources._8;
            this.right_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.right_panel.Location = new System.Drawing.Point(296, 0);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(976, 561);
            this.right_panel.TabIndex = 4;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(140, 473);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 7;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(56, 473);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 8;
            this.load.Text = "load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1272, 561);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.right_panel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "OrderIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label name;
        public System.Windows.Forms.Panel right_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
    }
}

