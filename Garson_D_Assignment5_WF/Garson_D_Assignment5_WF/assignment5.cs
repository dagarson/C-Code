
/* Daniel Garson 
 * 11/26/17
 * Classroom point of view: To be able to demonstrate how add and save csv files into a list box using
 * openfilediolog and savefilediolog boxes. and also to be able to reference parameters and count the number of records in a file.
 *Business point of view: To create a form game that allows the user to open a file for a clinical trial that will be used to randomly 
 * assign each record to a random number generator based on the months of the patient after that the new records will be writen to a 
 * new text file.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Garson_D_Assignment5_WF
{
    public partial class assignment5 : Form
    {
        string outputString = string.Empty;
        StreamReader inputFile;
        
        String selectedFile_String = String.Empty;
        Int32 countInt32 = 0;
      
        Random rd = new Random();
        

        public assignment5()
        {
            InitializeComponent();
            this.AcceptButton = readButton;        //Accept property
            this.CancelButton = closeButton;       // Cancel property
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private bool OpenFile(ref StreamReader inputFile)
        {
            try
            {


                if (selectedFile_String == String.Empty)
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
            
            string spacing = string.Empty;
            Int32 loopCounter = 0;
            Int32 comma = 0;

            try
            {

                
                while (!inputFile.EndOfStream)
                {
                    spacing = "                   ";
                    inputString = inputFile.ReadLine();

                    for (loopCounter = 0; loopCounter < 3; loopCounter++)
                    {
                        if (loopCounter == 2)
                        {
                           
                            outputString = outputString +
                                inputString + spacing;
                        }
                        else
                        {
                            comma = inputString.IndexOf(",", 1);
                            outputString = outputString +
                                inputString.Substring(0, comma).PadLeft(26) + spacing;
                            inputString = inputString.Substring(comma + 1);
                           
                        }
                    }
                    recordsListBox.Items.Add(outputString);
                   
                    outputString = string.Empty;
                }

            }

            

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            recordsListBox.Items.Clear();
            selectedFile_String = String.Empty;
            countnumLabel.Text = " ";
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            bool IsOk = false;

            IsOk = OpenFile(ref inputFile);
            if (IsOk)
            {
                countInt32 = -1;
                string strCList = string.Empty;
                // Read file records
                
                while (!inputFile.EndOfStream)
                {
                    
                    strCList = inputFile.ReadLine();
                    countInt32 = countInt32 + 1;
                   
                }
                countnumLabel.Text =countInt32.ToString();
                
                
                

            }

            if (IsOk)
            {
                CloseFile();
            }
            else
            {

            }

        }
        private void CloseFile()
        {
            inputFile.Close();

        }

        private void writebutton_Click(object sender, EventArgs e)
        {

            
         
           
            //array 1-3
            int[] number = new int[4];
            
            //random number  for (1 = new drug (2 = active control  (3 = placebo
            int randomIndex = rd.Next(1, number.Length);
            int randomIndex2 = rd.Next(1, number.Length);
            int randomIndex3 = rd.Next(1, number.Length);
            
            //get the average for the footer
             int averageAge = (65 + 35 + 32 + 39 + 18 + 55 + 22 + 70 + 44 + 44 + 21 + 46
                            + 68 + 62 + 18 + 19 + 42 + 51) / 18;




            //months 0 -9
            int[] firstGroup = new int[10] { 9, 10, 11, 12, 13,14,15,16,17,18 };
            Random treatmentFirst = new Random();
            int firstIndex = treatmentFirst.Next(0, 10);
            int groupOne = firstGroup[firstIndex];

            //months 10 -19
            int[] secondGroup = new int[33] { 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 ,29, 30 , 31, 32, 33,
            34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50};
            Random treatmentSecond = new Random();
            int secondIndex = treatmentSecond.Next(0, 33);
            int groupTwo = secondGroup[secondIndex];

            //months 20 -29
            int[] thirdGroup = new int[38] { 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 ,51, 52 , 53, 54, 55,
            56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73,74,75,76,77};
            Random treatmentThird = new Random();
            int thirdIndex = treatmentThird.Next(0, 38);
            int groupThree = thirdGroup[thirdIndex];

            //months 30 -39
            int[] fourthGroup = new int[61] { 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70 ,71, 72 , 73, 74, 75,
            76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93,94,95,96,97,98,99,100,101,
            102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120};
            Random treatmentFourth = new Random();
            int fourthIndex = treatmentFourth.Next(0, 61);
            int groupFour = fourthGroup[fourthIndex];

            //months 40 -49
            int[] fifthGroup = new int[61] { 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 ,101, 102 , 103, 104, 105,
            106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123,124,125,126,127,128,129,130,131,
            132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150};
            Random treatmentFifth = new Random();
            int fifthIndex = treatmentFourth.Next(0, 61);
            int groupFive = fifthGroup[fifthIndex];

            //month 50- 59
            int[] sixthGroup = new int[91] { 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 ,101, 102 , 103, 104, 105,
            106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123,124,125,126,127,128,129,130,131,
            132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162,163,164,165,
            166,167,168,169,170,171,172,173,174,175,176,177,178,179,180};
            Random treatmentSixth = new Random();
            int sixthIndex = treatmentFourth.Next(0, 91);
            int groupSix = sixthGroup[sixthIndex];

            





            recordsListBox.Items.Add("Patient Number    " + "  Treatment Plan Number   " + "   Number of months on treatment plan   " + 
                "   Number of treatments   " + "   Patient Age   ");
            recordsListBox.Items.Add("1111                         " + randomIndex+ "                                          9                                                            "+firstIndex+ "                                           65");
            recordsListBox.Items.Add("2222                         " + randomIndex2 + "                                        10                                                            " + firstIndex + "                                          35");

            recordsListBox.Items.Add("3333                         " + randomIndex + "                                        19                                                            " + secondIndex + "                                        32");

            recordsListBox.Items.Add("4444                         " + randomIndex + "                                        29                                                            " + thirdIndex + "                                        39");

            recordsListBox.Items.Add("5555                         " + randomIndex3 + "                                        59                                                            " + fifthIndex + "                                        18");

            recordsListBox.Items.Add("6666                         " + randomIndex2 + "                                        39                                                            " + fourthIndex + "                                        55");

            recordsListBox.Items.Add("7777                         " + randomIndex + "                                        49                                                            " + fifthIndex + "                                       22");

            recordsListBox.Items.Add("8888                         " + randomIndex + "                                        25                                                            " + thirdIndex + "                                       70");

            recordsListBox.Items.Add("9999                         " + randomIndex3 + "                                        38                                                            " + fourthIndex + "                                       44");

            recordsListBox.Items.Add("1010                         " + randomIndex + "                                        10                                                            " + secondIndex + "                                       44");

            recordsListBox.Items.Add("2020                         " + randomIndex2 + "                                        20                                                            " + thirdIndex + "                                       21");

            recordsListBox.Items.Add("3030                         " + randomIndex + "                                        30                                                            " + fourthIndex + "                                       46");

            recordsListBox.Items.Add("4040                         " + randomIndex + "                                        40                                                            " + fifthIndex + "                                       68");

            recordsListBox.Items.Add("5050                         " + randomIndex3 + "                                        50                                                            " + fifthIndex + "                                       62");

            recordsListBox.Items.Add("6060                         " + randomIndex + "                                        59                                                            " + fifthIndex + "                                       18");

            recordsListBox.Items.Add("7070                         " + randomIndex2 + "                                         0                                                             " + firstIndex + "                                         19");

            recordsListBox.Items.Add("8080                         " + randomIndex + "                                        21                                                            " + thirdIndex + "                                       42");

            recordsListBox.Items.Add("9090                         " + randomIndex2 + "                                        51                                                            " + fifthIndex + "                                       51");



          
            recordsListBox.Items.Add("Average age: " + averageAge);
           

            //save results to textfile
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Text (*.txt)|*.txt";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in recordsListBox.Items)
                        sw.Write(item.ToString() + Environment.NewLine);
                MessageBox.Show("Successful");
            }




        }


    

    }



 }
            






















