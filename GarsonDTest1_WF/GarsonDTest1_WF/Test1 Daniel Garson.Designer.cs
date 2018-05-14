namespace GarsonDTest1_WF
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
            this.displayButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.treePictureBox = new System.Windows.Forms.PictureBox();
            this.cherryButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.peachButton = new System.Windows.Forms.Button();
            this.appleButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.treePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(16, 150);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(98, 42);
            this.displayButton.TabIndex = 0;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(12, 75);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(83, 20);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Username";
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(115, 75);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.userTextBox.Size = new System.Drawing.Size(100, 26);
            this.userTextBox.TabIndex = 2;
            // 
            // treePictureBox
            // 
            this.treePictureBox.Image = global::GarsonDTest1_WF.Properties.Resources.Bing_Cherry;
            this.treePictureBox.Location = new System.Drawing.Point(417, 12);
            this.treePictureBox.Name = "treePictureBox";
            this.treePictureBox.Size = new System.Drawing.Size(273, 302);
            this.treePictureBox.TabIndex = 3;
            this.treePictureBox.TabStop = false;
            // 
            // cherryButton
            // 
            this.cherryButton.Location = new System.Drawing.Point(505, 336);
            this.cherryButton.Name = "cherryButton";
            this.cherryButton.Size = new System.Drawing.Size(91, 46);
            this.cherryButton.TabIndex = 4;
            this.cherryButton.Text = "Cherry";
            this.cherryButton.UseVisualStyleBackColor = true;
            this.cherryButton.Click += new System.EventHandler(this.cherryButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(311, 414);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(98, 56);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(115, 414);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 56);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // peachButton
            // 
            this.peachButton.Location = new System.Drawing.Point(505, 404);
            this.peachButton.Name = "peachButton";
            this.peachButton.Size = new System.Drawing.Size(91, 53);
            this.peachButton.TabIndex = 7;
            this.peachButton.Text = "Peach";
            this.peachButton.UseVisualStyleBackColor = true;
            this.peachButton.Click += new System.EventHandler(this.peachButton_Click);
            // 
            // appleButton
            // 
            this.appleButton.Location = new System.Drawing.Point(505, 482);
            this.appleButton.Name = "appleButton";
            this.appleButton.Size = new System.Drawing.Size(91, 46);
            this.appleButton.TabIndex = 8;
            this.appleButton.Text = "Apple";
            this.appleButton.UseVisualStyleBackColor = true;
            this.appleButton.Click += new System.EventHandler(this.appleButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(184, 150);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 24);
            this.displayLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 558);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.appleButton);
            this.Controls.Add(this.peachButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.cherryButton);
            this.Controls.Add(this.treePictureBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.displayButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.treePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.PictureBox treePictureBox;
        private System.Windows.Forms.Button cherryButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button peachButton;
        private System.Windows.Forms.Button appleButton;
        private System.Windows.Forms.Label displayLabel;
    }
}

