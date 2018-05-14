/* Daniel Garson 
 * 11/2/17
 * Classroom point of view: To be able to demonstrate how add csv files into a list box using
 * openfilediolog boxes. and also to be able to reference parameters.
 *Business point of view: To create a form game that allows the user to open a diologbox that will 
 * allow them to add a csv file into a listbox and then close the form after the data has been displayed.
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
using System.IO;

namespace Garson_D_Project4_ReadCSV_WF
{
    public partial class ReadCSV : Form

    {

 StreamReader inputFile;
       

        public ReadCSV()
        {
            InitializeComponent();

            

            this.AcceptButton = readButton;        //Accept property
            this.CancelButton = exitButton;         // Cancel property
        }







        private void readButton_Click(object sender, EventArgs e)
        {
            bool readtrue = false;
            readtrue = OpenFile(ref inputFile);
            

            if (readtrue)
            {
                readtrue = ProcessFile(inputFile);
                
            }

            if (readtrue)
            {
              
                inputFile.Close();
            }
           
        }

          
       private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    



        private bool OpenFile(ref StreamReader inputFile)
        {
            try
            {
                openFileDialog1.InitialDirectory = Environment.CurrentDirectory;

                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog1.FileName);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                return false;
            }

        }
               
               
        

        private bool ProcessFile(StreamReader inputFile)
        {
            string inputString = " ";
            string outputString = string.Empty;
            string space = string.Empty;
            Int32 loopCounter = 0;
            Int32 comma = 0;

            try
            {

                
                while (!inputFile.EndOfStream)
                {
                    space = "                   ";
                    inputString = inputFile.ReadLine();

                    for (loopCounter = 0; loopCounter < 3; loopCounter++)
                    {
                        if (loopCounter == 2)
                        {
                           
                            outputString = outputString +
                                inputString + space;
                        }
                        else
                        {
                            comma = inputString.IndexOf(",", 1);
                            outputString = outputString +
                                inputString.Substring(0, comma).PadLeft(26) + space;
                            inputString = inputString.Substring(comma + 1);
                           
                        }
                    }
                    csvListBox.Items.Add(outputString);
                   
                    outputString = string.Empty;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

    }
}    
         
    


    
       

      

        
    

