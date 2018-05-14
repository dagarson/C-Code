namespace Garson_D_Program1_PlantOrder
{
    partial class Form1
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
            this.maskedTextBox_name = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_street = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_state = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_zip = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_phone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_city = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.radioButton_red = new System.Windows.Forms.RadioButton();
            this.radioButton_green = new System.Windows.Forms.RadioButton();
            this.radioButton_blue = new System.Windows.Forms.RadioButton();
            this.button_clear = new System.Windows.Forms.Button();
            this.radioButton_purple = new System.Windows.Forms.RadioButton();
            this.maskedTextBox_plant = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_rose = new System.Windows.Forms.Button();
            this.button_lilac = new System.Windows.Forms.Button();
            this.button_snapdragon = new System.Windows.Forms.Button();
            this.button_tulip = new System.Windows.Forms.Button();
            this.button_display = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_information = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.checkBox_return = new System.Windows.Forms.CheckBox();
            this.label_return = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBox_name
            // 
            this.maskedTextBox_name.Location = new System.Drawing.Point(23, 48);
            this.maskedTextBox_name.Name = "maskedTextBox_name";
            this.maskedTextBox_name.Size = new System.Drawing.Size(111, 20);
            this.maskedTextBox_name.TabIndex = 0;
            // 
            // maskedTextBox_street
            // 
            this.maskedTextBox_street.Location = new System.Drawing.Point(23, 100);
            this.maskedTextBox_street.Name = "maskedTextBox_street";
            this.maskedTextBox_street.Size = new System.Drawing.Size(111, 20);
            this.maskedTextBox_street.TabIndex = 1;
            // 
            // maskedTextBox_state
            // 
            this.maskedTextBox_state.Location = new System.Drawing.Point(23, 224);
            this.maskedTextBox_state.Name = "maskedTextBox_state";
            this.maskedTextBox_state.Size = new System.Drawing.Size(111, 20);
            this.maskedTextBox_state.TabIndex = 2;
            this.maskedTextBox_state.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // maskedTextBox_zip
            // 
            this.maskedTextBox_zip.Location = new System.Drawing.Point(23, 277);
            this.maskedTextBox_zip.Name = "maskedTextBox_zip";
            this.maskedTextBox_zip.Size = new System.Drawing.Size(111, 20);
            this.maskedTextBox_zip.TabIndex = 3;
            // 
            // maskedTextBox_phone
            // 
            this.maskedTextBox_phone.Location = new System.Drawing.Point(23, 335);
            this.maskedTextBox_phone.Name = "maskedTextBox_phone";
            this.maskedTextBox_phone.Size = new System.Drawing.Size(111, 20);
            this.maskedTextBox_phone.TabIndex = 4;
            // 
            // maskedTextBox_city
            // 
            this.maskedTextBox_city.Location = new System.Drawing.Point(23, 160);
            this.maskedTextBox_city.Name = "maskedTextBox_city";
            this.maskedTextBox_city.Size = new System.Drawing.Size(111, 20);
            this.maskedTextBox_city.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Street Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone number";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(279, 509);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(103, 39);
            this.button_close.TabIndex = 12;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(638, 332);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Garson_D_Program1_PlantOrder.Properties.Resources.tulip;
            this.pictureBox.Location = new System.Drawing.Point(620, 112);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(144, 213);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // radioButton_red
            // 
            this.radioButton_red.AutoSize = true;
            this.radioButton_red.Location = new System.Drawing.Point(76, 19);
            this.radioButton_red.Name = "radioButton_red";
            this.radioButton_red.Size = new System.Drawing.Size(45, 17);
            this.radioButton_red.TabIndex = 15;
            this.radioButton_red.TabStop = true;
            this.radioButton_red.Text = "Red";
            this.radioButton_red.UseVisualStyleBackColor = true;
            this.radioButton_red.CheckedChanged += new System.EventHandler(this.radioButton_red_CheckedChanged);
            // 
            // radioButton_green
            // 
            this.radioButton_green.AutoSize = true;
            this.radioButton_green.Location = new System.Drawing.Point(76, 55);
            this.radioButton_green.Name = "radioButton_green";
            this.radioButton_green.Size = new System.Drawing.Size(54, 17);
            this.radioButton_green.TabIndex = 16;
            this.radioButton_green.TabStop = true;
            this.radioButton_green.Text = "Green";
            this.radioButton_green.UseVisualStyleBackColor = true;
            this.radioButton_green.CheckedChanged += new System.EventHandler(this.radioButton_green_CheckedChanged);
            // 
            // radioButton_blue
            // 
            this.radioButton_blue.AutoSize = true;
            this.radioButton_blue.Location = new System.Drawing.Point(76, 99);
            this.radioButton_blue.Name = "radioButton_blue";
            this.radioButton_blue.Size = new System.Drawing.Size(46, 17);
            this.radioButton_blue.TabIndex = 17;
            this.radioButton_blue.TabStop = true;
            this.radioButton_blue.Text = "Blue";
            this.radioButton_blue.UseVisualStyleBackColor = true;
            this.radioButton_blue.CheckedChanged += new System.EventHandler(this.radioButton_blue_CheckedChanged);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(279, 441);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(103, 40);
            this.button_clear.TabIndex = 18;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton_purple
            // 
            this.radioButton_purple.AutoSize = true;
            this.radioButton_purple.Location = new System.Drawing.Point(76, 145);
            this.radioButton_purple.Name = "radioButton_purple";
            this.radioButton_purple.Size = new System.Drawing.Size(55, 17);
            this.radioButton_purple.TabIndex = 19;
            this.radioButton_purple.TabStop = true;
            this.radioButton_purple.Text = "Purple";
            this.radioButton_purple.UseVisualStyleBackColor = true;
            this.radioButton_purple.CheckedChanged += new System.EventHandler(this.radioButton_yellow_CheckedChanged);
            // 
            // maskedTextBox_plant
            // 
            this.maskedTextBox_plant.Location = new System.Drawing.Point(23, 399);
            this.maskedTextBox_plant.Name = "maskedTextBox_plant";
            this.maskedTextBox_plant.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_plant.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Number of Plants";
            // 
            // button_rose
            // 
            this.button_rose.Location = new System.Drawing.Point(47, 25);
            this.button_rose.Name = "button_rose";
            this.button_rose.Size = new System.Drawing.Size(88, 36);
            this.button_rose.TabIndex = 22;
            this.button_rose.Text = "Rose";
            this.button_rose.UseVisualStyleBackColor = true;
            this.button_rose.Click += new System.EventHandler(this.button_rose_Click);
            // 
            // button_lilac
            // 
            this.button_lilac.Location = new System.Drawing.Point(47, 82);
            this.button_lilac.Name = "button_lilac";
            this.button_lilac.Size = new System.Drawing.Size(88, 35);
            this.button_lilac.TabIndex = 23;
            this.button_lilac.Text = "Lilac";
            this.button_lilac.UseVisualStyleBackColor = true;
            this.button_lilac.Click += new System.EventHandler(this.button_lilac_Click);
            // 
            // button_snapdragon
            // 
            this.button_snapdragon.Location = new System.Drawing.Point(47, 135);
            this.button_snapdragon.Name = "button_snapdragon";
            this.button_snapdragon.Size = new System.Drawing.Size(88, 34);
            this.button_snapdragon.TabIndex = 24;
            this.button_snapdragon.Text = "Snapdragon";
            this.button_snapdragon.UseVisualStyleBackColor = true;
            this.button_snapdragon.Click += new System.EventHandler(this.button_snapdragon_Click);
            // 
            // button_tulip
            // 
            this.button_tulip.Location = new System.Drawing.Point(47, 193);
            this.button_tulip.Name = "button_tulip";
            this.button_tulip.Size = new System.Drawing.Size(88, 35);
            this.button_tulip.TabIndex = 25;
            this.button_tulip.Text = "Tulip";
            this.button_tulip.UseVisualStyleBackColor = true;
            this.button_tulip.Click += new System.EventHandler(this.button_tulip_Click);
            // 
            // button_display
            // 
            this.button_display.Location = new System.Drawing.Point(279, 378);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(103, 41);
            this.button_display.TabIndex = 26;
            this.button_display.Text = "Display";
            this.button_display.UseVisualStyleBackColor = true;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_rose);
            this.groupBox1.Controls.Add(this.button_lilac);
            this.groupBox1.Controls.Add(this.button_tulip);
            this.groupBox1.Controls.Add(this.button_snapdragon);
            this.groupBox1.Location = new System.Drawing.Point(399, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 257);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_red);
            this.groupBox2.Controls.Add(this.radioButton_green);
            this.groupBox2.Controls.Add(this.radioButton_blue);
            this.groupBox2.Controls.Add(this.radioButton_purple);
            this.groupBox2.Location = new System.Drawing.Point(619, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 174);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label_information
            // 
            this.label_information.AutoSize = true;
            this.label_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_information.Location = new System.Drawing.Point(177, 151);
            this.label_information.Name = "label_information";
            this.label_information.Size = new System.Drawing.Size(0, 16);
            this.label_information.TabIndex = 26;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(255, 14);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(264, 37);
            this.label_title.TabIndex = 29;
            this.label_title.Text = "Mail Order Plants";
            // 
            // checkBox_return
            // 
            this.checkBox_return.AutoSize = true;
            this.checkBox_return.Location = new System.Drawing.Point(279, 338);
            this.checkBox_return.Name = "checkBox_return";
            this.checkBox_return.Size = new System.Drawing.Size(119, 17);
            this.checkBox_return.TabIndex = 30;
            this.checkBox_return.Text = "Returning Customer";
            this.checkBox_return.UseVisualStyleBackColor = true;
            this.checkBox_return.CheckedChanged += new System.EventHandler(this.checkBox_return_CheckedChanged);
            // 
            // label_return
            // 
            this.label_return.AutoSize = true;
            this.label_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_return.Location = new System.Drawing.Point(233, 100);
            this.label_return.Name = "label_return";
            this.label_return.Size = new System.Drawing.Size(0, 16);
            this.label_return.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 583);
            this.Controls.Add(this.label_return);
            this.Controls.Add(this.checkBox_return);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_information);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBox_plant);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox_city);
            this.Controls.Add(this.maskedTextBox_phone);
            this.Controls.Add(this.maskedTextBox_zip);
            this.Controls.Add(this.maskedTextBox_state);
            this.Controls.Add(this.maskedTextBox_street);
            this.Controls.Add(this.maskedTextBox_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_name;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_street;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_state;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_zip;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_phone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_city;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton radioButton_red;
        private System.Windows.Forms.RadioButton radioButton_green;
        private System.Windows.Forms.RadioButton radioButton_blue;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.RadioButton radioButton_purple;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_plant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_rose;
        private System.Windows.Forms.Button button_lilac;
        private System.Windows.Forms.Button button_snapdragon;
        private System.Windows.Forms.Button button_tulip;
        private System.Windows.Forms.Button button_display;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_information;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.CheckBox checkBox_return;
        private System.Windows.Forms.Label label_return;
    }
}

