/* Daniel Garson
 * CIS 237
 * 1/24/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class Program
    {   
        //test for if file loaded
        public static bool ProcessArrayExecuted = false;

        //test to see if file updated
       public static bool Added = false;
        static void Main(string[] args)
        {


            int Prompt = UserInterface.GetUserInput();
            //Declare Array
            WineItem[] Winelist = new WineItem[4000];

            //Textfile
            string CSV = "../../../datafiles/WineList.csv";
            ProcessArrayExecuted = true;



            if (Prompt == 1)
            {
                WineItemCollection Loaded = new WineItemCollection();
                Loaded.ArrayLoaded();


                Prompt = UserInterface.GetUserInput();

            }
            if (Prompt == 2)
            {

                WineItemCollection csvdisplay = new WineItemCollection();

                csvdisplay.WineCSV(CSV, Winelist);

                string outputString = "";


                foreach (WineItem Wine in Winelist)
                {
                    if (Wine != null)
                    {
                        outputString += Wine.ToString() +
                            Environment.NewLine;
                    }
                }

                UserInterface.Output(outputString);
                Prompt = UserInterface.GetUserInput();



            }

            if (Prompt == 3)
            {
                WineItemCollection Locate = new WineItemCollection();
                Locate.Search();
                Prompt = UserInterface.GetUserInput();

            }

            if (Prompt == 4)
            {

                
                //add record to text file 
                Winelist[3964] = new WineItem("52562", "123 Westnedge ave", "700 ml");
                Added = true;

                WineItemCollection RecordAdded = new WineItemCollection();
                RecordAdded.Add();
                Prompt = UserInterface.GetUserInput();

            }
            if (Prompt == 5)
            {

                exit();

            }



            //re-promp the user for input 
            Prompt = UserInterface.GetUserInput();

        }

       
       
    
        static void exit()
        {

            Environment.Exit(0);

        }
    

    }
    }
    
    




