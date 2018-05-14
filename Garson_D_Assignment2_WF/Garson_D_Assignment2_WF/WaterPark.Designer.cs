namespace Garson_D_Assignment2_WF
{
    partial class WaterPark
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
            this.exitButton = new System.Windows.Forms.Button();
            this.groupLabel = new System.Windows.Forms.Label();
            this.groupTextBox = new System.Windows.Forms.MaskedTextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.minutesTextBox = new System.Windows.Forms.MaskedTextBox();
            this.attractionGroupBox = new System.Windows.Forms.GroupBox();
            this.slideCheckbox = new System.Windows.Forms.CheckBox();
            this.riverCheckbox = new System.Windows.Forms.CheckBox();
            this.poolCheckbox = new System.Windows.Forms.CheckBox();
            this.tubingCheckbox = new System.Windows.Forms.CheckBox();
            this.kpoolCheckbox = new System.Windows.Forms.CheckBox();
            this.discountGroupbox = new System.Windows.Forms.GroupBox();
            this.twentyRadioButton = new System.Windows.Forms.RadioButton();
            this.tenRadioButton = new System.Windows.Forms.RadioButton();
            this.fiveRadioButton = new System.Windows.Forms.RadioButton();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.resetButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.customerButton = new System.Windows.Forms.Button();
            this.manageButton = new System.Windows.Forms.Button();
            this.attractionGroupBox.SuspendLayout();
            this.discountGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(542, 398);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 42);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLabel.Location = new System.Drawing.Point(22, 39);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(85, 16);
            this.groupLabel.TabIndex = 1;
            this.groupLabel.Text = "Group Name";
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(279, 39);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(100, 20);
            this.groupTextBox.TabIndex = 2;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(24, 83);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(201, 16);
            this.numberLabel.TabIndex = 3;
            this.numberLabel.Text = "Number of people(in your group)";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(279, 83);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 4;
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(22, 133);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(97, 13);
            this.minutesLabel.TabIndex = 5;
            this.minutesLabel.Text = "Minutes in the park";
            // 
            // minutesTextBox
            // 
            this.minutesTextBox.Location = new System.Drawing.Point(279, 133);
            this.minutesTextBox.Name = "minutesTextBox";
            this.minutesTextBox.Size = new System.Drawing.Size(100, 20);
            this.minutesTextBox.TabIndex = 6;
            // 
            // attractionGroupBox
            // 
            this.attractionGroupBox.Controls.Add(this.slideCheckbox);
            this.attractionGroupBox.Controls.Add(this.riverCheckbox);
            this.attractionGroupBox.Controls.Add(this.poolCheckbox);
            this.attractionGroupBox.Controls.Add(this.tubingCheckbox);
            this.attractionGroupBox.Controls.Add(this.kpoolCheckbox);
            this.attractionGroupBox.Location = new System.Drawing.Point(27, 164);
            this.attractionGroupBox.Name = "attractionGroupBox";
            this.attractionGroupBox.Size = new System.Drawing.Size(208, 149);
            this.attractionGroupBox.TabIndex = 7;
            this.attractionGroupBox.TabStop = false;
            this.attractionGroupBox.Text = "Attractions";
            // 
            // slideCheckbox
            // 
            this.slideCheckbox.AutoSize = true;
            this.slideCheckbox.Location = new System.Drawing.Point(63, 125);
            this.slideCheckbox.Name = "slideCheckbox";
            this.slideCheckbox.Size = new System.Drawing.Size(81, 17);
            this.slideCheckbox.TabIndex = 12;
            this.slideCheckbox.Text = "Water Slide";
            this.slideCheckbox.UseVisualStyleBackColor = true;
            // 
            // riverCheckbox
            // 
            this.riverCheckbox.AutoSize = true;
            this.riverCheckbox.Location = new System.Drawing.Point(118, 81);
            this.riverCheckbox.Name = "riverCheckbox";
            this.riverCheckbox.Size = new System.Drawing.Size(76, 17);
            this.riverCheckbox.TabIndex = 11;
            this.riverCheckbox.Text = "Lazy River";
            this.riverCheckbox.UseVisualStyleBackColor = true;
            // 
            // poolCheckbox
            // 
            this.poolCheckbox.AutoSize = true;
            this.poolCheckbox.Location = new System.Drawing.Point(12, 81);
            this.poolCheckbox.Name = "poolCheckbox";
            this.poolCheckbox.Size = new System.Drawing.Size(97, 17);
            this.poolCheckbox.TabIndex = 10;
            this.poolCheckbox.Text = "Swimming Pool";
            this.poolCheckbox.UseVisualStyleBackColor = true;
            // 
            // tubingCheckbox
            // 
            this.tubingCheckbox.AutoSize = true;
            this.tubingCheckbox.Location = new System.Drawing.Point(118, 33);
            this.tubingCheckbox.Name = "tubingCheckbox";
            this.tubingCheckbox.Size = new System.Drawing.Size(86, 17);
            this.tubingCheckbox.TabIndex = 9;
            this.tubingCheckbox.Text = "Inner Tubing";
            this.tubingCheckbox.UseVisualStyleBackColor = true;
            // 
            // kpoolCheckbox
            // 
            this.kpoolCheckbox.AutoSize = true;
            this.kpoolCheckbox.Location = new System.Drawing.Point(12, 33);
            this.kpoolCheckbox.Name = "kpoolCheckbox";
            this.kpoolCheckbox.Size = new System.Drawing.Size(79, 17);
            this.kpoolCheckbox.TabIndex = 8;
            this.kpoolCheckbox.Text = "Kiddie Pool";
            this.kpoolCheckbox.UseVisualStyleBackColor = true;
            // 
            // discountGroupbox
            // 
            this.discountGroupbox.Controls.Add(this.twentyRadioButton);
            this.discountGroupbox.Controls.Add(this.tenRadioButton);
            this.discountGroupbox.Controls.Add(this.fiveRadioButton);
            this.discountGroupbox.Controls.Add(this.noneRadioButton);
            this.discountGroupbox.Location = new System.Drawing.Point(279, 164);
            this.discountGroupbox.Name = "discountGroupbox";
            this.discountGroupbox.Size = new System.Drawing.Size(100, 165);
            this.discountGroupbox.TabIndex = 13;
            this.discountGroupbox.TabStop = false;
            this.discountGroupbox.Text = "Discount coupons";
            // 
            // twentyRadioButton
            // 
            this.twentyRadioButton.AutoSize = true;
            this.twentyRadioButton.Location = new System.Drawing.Point(5, 132);
            this.twentyRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.twentyRadioButton.Name = "twentyRadioButton";
            this.twentyRadioButton.Size = new System.Drawing.Size(45, 17);
            this.twentyRadioButton.TabIndex = 3;
            this.twentyRadioButton.TabStop = true;
            this.twentyRadioButton.Text = "20%";
            this.twentyRadioButton.UseVisualStyleBackColor = true;
            // 
            // tenRadioButton
            // 
            this.tenRadioButton.AutoSize = true;
            this.tenRadioButton.Location = new System.Drawing.Point(3, 94);
            this.tenRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tenRadioButton.Name = "tenRadioButton";
            this.tenRadioButton.Size = new System.Drawing.Size(45, 17);
            this.tenRadioButton.TabIndex = 2;
            this.tenRadioButton.TabStop = true;
            this.tenRadioButton.Text = "10%";
            this.tenRadioButton.UseVisualStyleBackColor = true;
            // 
            // fiveRadioButton
            // 
            this.fiveRadioButton.AutoSize = true;
            this.fiveRadioButton.Location = new System.Drawing.Point(3, 54);
            this.fiveRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fiveRadioButton.Name = "fiveRadioButton";
            this.fiveRadioButton.Size = new System.Drawing.Size(39, 17);
            this.fiveRadioButton.TabIndex = 1;
            this.fiveRadioButton.TabStop = true;
            this.fiveRadioButton.Text = "5%";
            this.fiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.Location = new System.Drawing.Point(3, 15);
            this.noneRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(51, 17);
            this.noneRadioButton.TabIndex = 0;
            this.noneRadioButton.TabStop = true;
            this.noneRadioButton.Text = "None";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(399, 398);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(102, 42);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.AutoSize = true;
            this.receiptLabel.Location = new System.Drawing.Point(384, 72);
            this.receiptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(0, 13);
            this.receiptLabel.TabIndex = 15;
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(166, 398);
            this.receiptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(86, 42);
            this.receiptButton.TabIndex = 16;
            this.receiptButton.Text = "Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(411, 24);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(0, 17);
            this.headerLabel.TabIndex = 17;
            // 
            // customerButton
            // 
            this.customerButton.Location = new System.Drawing.Point(284, 398);
            this.customerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(94, 42);
            this.customerButton.TabIndex = 18;
            this.customerButton.Text = "New Customer";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // manageButton
            // 
            this.manageButton.Location = new System.Drawing.Point(39, 398);
            this.manageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(88, 42);
            this.manageButton.TabIndex = 19;
            this.manageButton.Text = "Management Total";
            this.manageButton.UseVisualStyleBackColor = true;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // WaterPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 492);
            this.Controls.Add(this.manageButton);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.discountGroupbox);
            this.Controls.Add(this.attractionGroupBox);
            this.Controls.Add(this.minutesTextBox);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.exitButton);
            this.Name = "WaterPark";
            this.Text = "WaterPark";
            this.Load += new System.EventHandler(this.WaterPark_Load);
            this.attractionGroupBox.ResumeLayout(false);
            this.attractionGroupBox.PerformLayout();
            this.discountGroupbox.ResumeLayout(false);
            this.discountGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.MaskedTextBox groupTextBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.MaskedTextBox numberTextBox;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.MaskedTextBox minutesTextBox;
        private System.Windows.Forms.GroupBox attractionGroupBox;
        private System.Windows.Forms.CheckBox slideCheckbox;
        private System.Windows.Forms.CheckBox riverCheckbox;
        private System.Windows.Forms.CheckBox poolCheckbox;
        private System.Windows.Forms.CheckBox tubingCheckbox;
        private System.Windows.Forms.CheckBox kpoolCheckbox;
        private System.Windows.Forms.GroupBox discountGroupbox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.RadioButton twentyRadioButton;
        private System.Windows.Forms.RadioButton tenRadioButton;
        private System.Windows.Forms.RadioButton fiveRadioButton;
        private System.Windows.Forms.RadioButton noneRadioButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button manageButton;
    }
}

