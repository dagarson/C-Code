namespace Garson_D_Assignment5_WF
{
    partial class assignment5
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
            this.writebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.recordsListBox = new System.Windows.Forms.ListBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.countnumLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(396, 623);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(125, 44);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "Read Records";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // writebutton
            // 
            this.writebutton.Location = new System.Drawing.Point(546, 623);
            this.writebutton.Name = "writebutton";
            this.writebutton.Size = new System.Drawing.Size(135, 44);
            this.writebutton.TabIndex = 1;
            this.writebutton.Text = "Write Records";
            this.writebutton.UseVisualStyleBackColor = true;
            this.writebutton.Click += new System.EventHandler(this.writebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(704, 623);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(112, 44);
            this.clearbutton.TabIndex = 2;
            this.clearbutton.Text = "Clear Listbox";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(271, 623);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(107, 44);
            this.countButton.TabIndex = 3;
            this.countButton.Text = "Count Records";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(840, 623);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(114, 44);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // recordsListBox
            // 
            this.recordsListBox.FormattingEnabled = true;
            this.recordsListBox.ItemHeight = 16;
            this.recordsListBox.Location = new System.Drawing.Point(144, 1);
            this.recordsListBox.Name = "recordsListBox";
            this.recordsListBox.Size = new System.Drawing.Size(810, 580);
            this.recordsListBox.TabIndex = 5;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(12, 630);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(185, 25);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "Number of Records:";
            // 
            // countnumLabel
            // 
            this.countnumLabel.AutoSize = true;
            this.countnumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countnumLabel.Location = new System.Drawing.Point(194, 630);
            this.countnumLabel.Name = "countnumLabel";
            this.countnumLabel.Size = new System.Drawing.Size(0, 25);
            this.countnumLabel.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // assignment5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 733);
            this.Controls.Add(this.countnumLabel);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.recordsListBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.writebutton);
            this.Controls.Add(this.readButton);
            this.Name = "assignment5";
            this.Text = "Assignment5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button writebutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox recordsListBox;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label countnumLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

