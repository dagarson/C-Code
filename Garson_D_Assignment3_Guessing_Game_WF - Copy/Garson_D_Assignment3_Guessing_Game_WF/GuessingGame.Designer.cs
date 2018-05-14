namespace Garson_D_Assignment3_Guessing_Game_WF
{
    partial class GuessingGame
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
            this.guessButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.wrongListBox = new System.Windows.Forms.ListBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.highorlowLabel = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(27, 110);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(95, 34);
            this.guessButton.TabIndex = 0;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(244, 295);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 49);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(390, 295);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 49);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // wrongListBox
            // 
            this.wrongListBox.FormattingEnabled = true;
            this.wrongListBox.Location = new System.Drawing.Point(330, 110);
            this.wrongListBox.Name = "wrongListBox";
            this.wrongListBox.Size = new System.Drawing.Size(172, 147);
            this.wrongListBox.TabIndex = 4;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(141, 110);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 31);
            this.inputTextBox.TabIndex = 5;
            // 
            // highorlowLabel
            // 
            this.highorlowLabel.AutoSize = true;
            this.highorlowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highorlowLabel.Location = new System.Drawing.Point(122, 191);
            this.highorlowLabel.Name = "highorlowLabel";
            this.highorlowLabel.Size = new System.Drawing.Size(0, 17);
            this.highorlowLabel.TabIndex = 6;
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Location = new System.Drawing.Point(125, 74);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(171, 13);
            this.directionLabel.TabIndex = 7;
            this.directionLabel.Text = "Enter an number between 1 to 100";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(27, 232);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 44);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // GuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 425);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.directionLabel);
            this.Controls.Add(this.highorlowLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.wrongListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.guessButton);
            this.Name = "GuessingGame";
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.GuessingGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox wrongListBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label highorlowLabel;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}

