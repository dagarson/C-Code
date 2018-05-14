
/* Daniel Garson 
 * 10/10/17
 * Classroom point of view: To be able to demonstrate how use switch case structures and if statements.
 * Along with being able to use different math operators such as accumulation and other conversions. 
 *Business point of view: To create a form for a waterpark that calculates different expenses that 
 * the customers will have and have them broken down into different parks and then added togeather 
 * for a grand total. 
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


namespace Garson_D_Assignment2_WF
{
    public partial class WaterPark : Form
    {

      
            string discount = "";
        int eventIn;
        int extraevent;
        double extraFee;
        double enterFee = 10.00;
        double enterResult;
        double totalResult;
        double totalCharge;
        double discountnum;
        double final;
        double finalTotal;

        //accumulator
        decimal totalgroup = 0m;
        decimal totalpeople = 0m;



        public WaterPark()
        {

            InitializeComponent();
           
        }

       


        private void WaterPark_Load(object sender, EventArgs e)
        {

        }
       
        private void Exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void receiptButton_Click(object sender, EventArgs e)
        {

            double parkingMinutes;


            parkingMinutes = double.Parse(minutesTextBox.Text);

            double hours = parkingMinutes / 60.0;

            double hoursParked = Math.Ceiling(hours * 2.0) / 2.0;

            double parkingCost = hoursParked * 2;


          totalResult =  double.Parse(numberTextBox.Text) * enterFee;

















            double feeResult;
            string kp = "";
            string it = "";
            string sp = "";
            string lr = "";
            string ws = "";

            if (noneRadioButton.Checked == true)
            {
                discount = "none";
                
            }

            if (fiveRadioButton.Checked == true)
            {
                discount = "5%";
                discountnum = 5;
                    }


            if (tenRadioButton.Checked == true)
            {
                discount = "10%";
                discountnum = 10;
            }




            if (twentyRadioButton.Checked == true)
            {
                discount = "20%";
                discountnum = 20;
            }

            if (kpoolCheckbox.Checked == true)
            {
                kp = "Kiddie Pool";
                
            }

            if (tubingCheckbox.Checked == true)
            {
                it = "Inner Tubing";
                
            }

            if (poolCheckbox.Checked == true)
            {
                sp = "Swimming pool";
                
            }

            if (riverCheckbox.Checked == true)
            {
                lr = "Lazy River";
                
            }

            if (slideCheckbox.Checked == true)
            {
                ws = "Water Slide";
                
            }




            if (kpoolCheckbox.Checked == true)
            { eventIn += 1; }
            if (tubingCheckbox.Checked == true)
            { eventIn += 1; }
            if (poolCheckbox.Checked == true)
            { eventIn += 1; }
            if (riverCheckbox.Checked == true)
            { eventIn += 1; }

            if (slideCheckbox.Checked == true)
            { eventIn +=1; }
             
                
                
                extraevent = eventIn - 1;

            switch (extraevent)
            {
                case 1:
                    extraFee = 3.00;
                    break;
                case 2:
                    extraFee = 5.00;
                    break;
                case 3:
                    extraFee = 6.00;
                    break;
                case 4:
                    extraFee = 7.00;
                    break;
                default:
                    extraFee = 00.00;
                    break;
            }

            enterResult = enterFee + extraFee;


            feeResult = extraFee * double.Parse(numberTextBox.Text);

            totalCharge = parkingCost + totalResult;

            final = totalCharge * discountnum / 100;
            finalTotal = totalCharge - final;

                    
            



            // Header Label
            headerLabel.Text = "207 WaterPark" + Environment.NewLine
                                 + DateTime.Now + Environment.NewLine +
                                 "Daniel Garson" + Environment.NewLine;

            //Receipt Label
            receiptLabel.Text = Environment.NewLine + "Group Name: " + groupTextBox.Text + Environment.NewLine +
                                "Number of People: " + numberTextBox.Text + Environment.NewLine +
                                "Hours in the Park: " + hoursParked + Environment.NewLine +
                                "Parking Fee: " + "$" + parkingCost + ".00" + Environment.NewLine +
                                "Attractions: " + Environment.NewLine
                                + kp + Environment.NewLine +
                                 Environment.NewLine + it +
                                 Environment.NewLine + sp +
                                 Environment.NewLine + lr +
                                 Environment.NewLine + ws +
                                 Environment.NewLine +
                                "Activity Fee: "+ "$" + feeResult+".00"+ Environment.NewLine +
                                "Entrance / Per Person fee: " +"$"+ enterResult+".00"+ "  $10.00 per person and 1 event"+ Environment.NewLine +
                                "Total Park Fee: " + "$"+ totalResult+".00"+ Environment.NewLine +
                                "Total Charge: " +"$"+totalCharge+".00"+ Environment.NewLine +
                                "Discount % and Amount: " + discount +
                                    Environment.NewLine +
                                "Final Total: " +finalTotal+ Environment.NewLine;
        }






        



















     

        private void resetButton_Click(object sender, EventArgs e)
        {
            //reset  accumulator
            totalgroup = 0m;
            totalpeople = 0m;
          
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            groupTextBox.Clear();
            numberTextBox.Clear();
            minutesTextBox.Clear();
            headerLabel.Text = "";
            receiptLabel.Text = "";
            kpoolCheckbox.Checked = false;
            poolCheckbox.Checked = false;
            tubingCheckbox.Checked = false;
            riverCheckbox.Checked = false;
            slideCheckbox.Checked = false;
            noneRadioButton.Checked = false;
            fiveRadioButton.Checked = false;
            tenRadioButton.Checked = false;
            twentyRadioButton.Checked = false;
        }
       
        private void manageButton_Click(object sender, EventArgs e)
        {


            decimal average;
            

            totalgroup++;

            totalpeople += decimal.Parse(numberTextBox.Text);

            average = totalpeople / totalgroup;
            

            

                MessageBox.Show("The total number of groups " + totalgroup  + Environment.NewLine
               + "The total number of people who attended the water park at that point " + totalpeople +
              Environment.NewLine + "Average Number of People per group "+ average);
            

             


          



             


        }

                    
                
                
        
    }



}

