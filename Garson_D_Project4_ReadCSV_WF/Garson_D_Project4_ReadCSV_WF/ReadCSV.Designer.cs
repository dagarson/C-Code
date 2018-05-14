namespace Garson_D_Project4_ReadCSV_WF
{
    partial class ReadCSV
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
            this.readButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.csvListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(44, 529);
            this.readButton.Margin = new System.Windows.Forms.Padding(4);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(155, 68);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "Read CSV";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(548, 529);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(145, 68);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // csvListBox
            // 
            this.csvListBox.FormattingEnabled = true;
            this.csvListBox.ItemHeight = 16;
            this.csvListBox.Location = new System.Drawing.Point(44, 68);
            this.csvListBox.Margin = new System.Windows.Forms.Padding(4);
            this.csvListBox.Name = "csvListBox";
            this.csvListBox.Size = new System.Drawing.Size(648, 420);
            this.csvListBox.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ReadCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 716);
            this.Controls.Add(this.csvListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.readButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReadCSV";
            this.Text = "Daniel Garson Assignment 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox csvListBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

