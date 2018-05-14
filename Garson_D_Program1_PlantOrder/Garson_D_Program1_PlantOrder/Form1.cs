/* Daniel Garson 
 * 9/22/17
 * Classroom point of view: To be able to demonstrate how to work with a form
 * and use the various buttons and checkboxes. 
 *Business point of view: To create a form for a company based out of Vicksburg MI 
 * who sells flowers and would like to have customers order some online by 
 * filling out some basic information and letting the user make their selection.
*/





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garson_D_Program1_PlantOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox.Image = null;
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            maskedTextBox_name.Clear();
            maskedTextBox_phone.Clear();
            maskedTextBox_plant.Clear();
            maskedTextBox_city.Clear();
            maskedTextBox_state.Clear();
            maskedTextBox_zip.Clear();
            maskedTextBox_street.Clear();
            pictureBox.Image = null;
            label_information.Text = "";
            label_return.Text = null;
            checkBox_return.Checked = false;




        }

        private void button_rose_Click(object sender, EventArgs e)
        {
            pictureBox.Visible = true;
            pictureBox.Image = Properties.Resources.rose;
            textBox1.Text = button_rose.Text;
        }

        private void button_lilac_Click(object sender, EventArgs e)
        {
            pictureBox.Visible = true;
            pictureBox.Image = Properties.Resources.lilac;
            textBox1.Text = button_lilac.Text;

        }

        private void button_snapdragon_Click(object sender, EventArgs e)
        {
            pictureBox.Visible = true;
            pictureBox.Image = Properties.Resources.snapdragon;
            textBox1.Text = button_snapdragon.Text;

        }

        private void button_tulip_Click(object sender, EventArgs e)
        {
            pictureBox.Visible = true;
            pictureBox.Image = Properties.Resources.tulip;
            textBox1.Text = button_tulip.Text;
        }

        private void radioButton_red_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void radioButton_green_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void radioButton_blue_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void radioButton_yellow_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Violet;
        }

        private void button_display_Click(object sender, EventArgs e)
        {
            label_information.Text = "Name: " + maskedTextBox_name.Text + Environment.NewLine + "Street Address: " + maskedTextBox_street.Text +
             Environment.NewLine + "City: " + maskedTextBox_city.Text + Environment.NewLine + "State: " + maskedTextBox_state.Text
             + Environment.NewLine + "Zip: " + maskedTextBox_zip.Text + Environment.NewLine + "Phone: " + maskedTextBox_phone.Text
            + Environment.NewLine + "# Plants: " + maskedTextBox_plant.Text + Environment.NewLine + "Plant: " + textBox1.Text;

     


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox_return_CheckedChanged(object sender, EventArgs e)
        {
            label_return.Text = "Welcome Back Returning Customer!";
        }
    }
}
// , ,  ,,