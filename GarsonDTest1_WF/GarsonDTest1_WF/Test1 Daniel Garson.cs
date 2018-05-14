using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarsonDTest1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treePictureBox.Image = null;
            
            CancelButton = exitButton;  //cancel property;
            displayLabel.BackColor = Color.Beige;        //light background color for display label
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show( "I see you like trees " + userTextBox.Text + ", good for you!");      //messagebox
            
            displayLabel.Text = userTextBox.Text ;
        }

        
         private void cherryButton_Click(object sender, EventArgs e)
            {
                treePictureBox.Image = Properties.Resources.Bing_Cherry;
           
            
            }
     
        private void peachButton_Click(object sender, EventArgs e)
        {
            treePictureBox.Image = Properties.Resources.Elberta_Peach;

           

            MessageBox.Show("Daniel Garson"+ Environment.NewLine+ "Peach Tree");

        }

        private void appleButton_Click(object sender, EventArgs e)
        {
            treePictureBox.Image = Properties.Resources.Red_Delicious_Apple;
            displayLabel.Text = userTextBox.Text + " Likes apples trees. ";

        }

       


   private void clearButton_Click(object sender, EventArgs e)
        {
            userTextBox.Clear();
            treePictureBox.Image = null;
            displayLabel.Text = "";
           
           
        }



private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
