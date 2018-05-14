/* Daniel Garson
 * date 12/7/17
 * Classroom point of view: to be able to make a console app that will write a file to the console 
 * also to be able to sort the names in Alphabetical order along with being able to find certain records 
 * in the text file. doing these things while using different methods and different ways not used in 
 * a form but used in a console app
 * Business pont of view: to make a program that allows the usere to first select what record they would like
 * to work with and then give them the abiity to read the records, sort the records Alphabetical and search 
 * for a specific record record.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garson_D_Assignment6_CA
{
    class Program
    {

         //note must double click each 1-5 selection due to pause method

        static void Main(string[] args)
        {
            Console.WriteLine("                     Menu         ");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1 – Work with Little Records file");
            Console.WriteLine("2 – Work with Big Records file");
            Console.WriteLine("	3 - Quit");
            Console.WriteLine("-------------------------------------------------------------------");

            string key = Console.ReadKey().Key.ToString();

                            //typed #1
            if (key.ToUpper() == "D1")
                displayLittle();


            else if         //typed #2
                (key.ToUpper() == "D2")
                displayBig();


            else if         //typed #3
                (key.ToUpper() == "D3")
                exit();




            Pause("Select key to continue:  ", true);




            
        }

                        //Display used for Little record
        static void displayLittle()
        {
            Console.WriteLine("                     Menu         ");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1 – show all student records (name and grade) as found in the file");
            Console.WriteLine("2 – find the grade of a student by his/her name");
            Console.WriteLine("3 – find & display all the names who have a certain (input by user) grade ");
            Console.WriteLine("4 – Sort Student Names");
            Console.WriteLine("	5 - Quit");
            Console.WriteLine("-------------------------------------------------------------------");






            Pause("Select key to continue:  ", true);

            string key = Console.ReadKey().Key.ToString();

                            //typed #1
            if (key.ToUpper() == "D1")
                readFileLittle();


            else if         //typed #2
                (key.ToUpper() == "D2")
                locateGradeLittle();

            else if         //typed #3
                (key.ToUpper() == "D3")
                locateNameLittle();

            else if        //typed #4
                (key.ToUpper() == "D4")
                sortRecordsLittle();

            else if        //typed #5
                (key.ToUpper() == "D5")
                exit();


          
        }

       
     

                        //Readfile for little record
        static void readFileLittle()
        {
                                                //remember to change filepath each different computer use
            StreamReader file = new StreamReader(@"E:\CIS 207\Garson_D_Assignment6_CA\Garson_D_Assignment6_CA\bin\Debug\LittleRecord.txt");

            string lineLittle = "";
            int counter = 0;




            while ((lineLittle = file.ReadLine()) != null)
            {
                string record = lineLittle;
                string littleSplit = string.Join(Environment.NewLine, record.Split(','));
                Console.WriteLine(littleSplit);


                counter++;
            }
            Pause("Press enter to continue:", true);
            displayLittle();

        }

                                //Locate method for Little record
        static void locateGradeLittle()
        {                                      //remember to change filepath each different computer use
            FileStream inFile = new FileStream(@"E:\CIS 207\Garson_D_Assignment6_CA\Garson_D_Assignment6_CA\bin\Debug\LittleRecord.txt", FileMode.Open, FileAccess.Read);
            StreamReader locate = new StreamReader(inFile);
            string record;
            string input;
            Console.Write("Enter the students name ");
            //convert user input to uppercase to ma
            input = Console.ReadLine().ToUpper();
            try
            {
                
                record = locate.ReadLine();
                while (record != null)
                {
                    if (record.Contains(input))
                    {
                        Console.WriteLine(record);
                    }
                    record = locate.ReadLine();
                }
            }
            finally
            {
               
                locate.Close();
                inFile.Close();
            }
            Pause("Press enter to continue:", true);
            displayLittle();
        }

                        //Locate method for little record
        static void locateNameLittle()
        {
            IEnumerable<string> lines = File.ReadAllLines(@"E:\CIS 207\Garson_D_Assignment6_CA\Garson_D_Assignment6_CA\bin\Debug\LittleRecord.txt");

            
            Console.Write("Enter the grade: ");
            string input = Console.ReadLine().Trim();

           
            IEnumerable<string> matches = !String.IsNullOrEmpty(input)
                                          ? lines.Where(line => line.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                                          : Enumerable.Empty<string>();

           
            Console.WriteLine(matches.Any()
                              ? String.Format("Matches:\n> {0}", String.Join("\n> ", matches))
                              : "There were no matching grades");
            Pause("Press enter to continue:", true);
            displayLittle();
        }
                            //sort method for little record
        static void sortRecordsLittle()
        {
                                               //remember to change filepath each different computer use
            StreamReader sr = new StreamReader(@"E:\CIS 207\Garson_D_Assignment6_CA\Garson_D_Assignment6_CA\bin\Debug\LittleRecord.txt");  

            var names = new List<string>();
            while (!sr.EndOfStream)
            {
                names.Add(sr.ReadLine());
            }

            names.Sort((x, y) => x.Split(',')[0].CompareTo(y.Split(',')[0]));

            foreach (var name in names)
                Console.WriteLine(name);
            Pause("Press enter to continue:", true);
            displayLittle();

        }
                                // main display for big record
        static void displayBig()
        {
            Console.WriteLine("                     Menu         ");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1 – show all student records (name and grade) as found in the file");
            Console.WriteLine("2 – find the grade of a student by his/her name");
            Console.WriteLine("3 – find & display all the names who have a certain (input by user) grade ");
            Console.WriteLine("4 – Sort Student Names");
            Console.WriteLine("	5 - Quit");
            Console.WriteLine("-------------------------------------------------------------------");






            Pause("Select key to continue:  ", true);

            string key = Console.ReadKey().Key.ToString();

                            //typed #1
            if (key.ToUpper() == "D1")
                readFileBig();


            else if         //typed #2
                (key.ToUpper() == "D2")
                locateGradeBig();

            else if         //typed #3
                (key.ToUpper() == "D3")
                locateNameBig();

            else if         //typed #4
                (key.ToUpper() == "D4")
                sortRecordsBig();

            else if         //typed #5
                (key.ToUpper() == "D5")
                exit();


           
        }




                                    //read records of big file
        static void readFileBig()
        {
                                                //remember to change filepath each different computer use
            StreamReader file = new StreamReader(@"E:\CIS 207\Garson_D_Assignment6_CA\Garson_D_Assignment6_CA\bin\Debug\BigRecord.txt");

            string lineBig = "";
            int counterBig = 0;



            while ((lineBig = file.ReadLine()) != null)

            {
                string record = lineBig;
                string bigSplit = string.Join(Environment.NewLine, record.Split(','));
                Console.WriteLine(bigSplit);

                counterBig++;
            }
            Pause("Press enter to continue:", true);
            displayBig();

        }

                                        //locate method of big record
        static void locateGradeBig()
        {                                        //remember to change filepath each different computer use
            FileStream inFile = new FileStream(@"E:\CIS 207\Garson_D_Assignment6_CA\Garson_D_Assignment6_CA\bin\Debug\BigRecord.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string record;
            string input;
            Console.Write("Enter the students name ");
            input = Console.ReadLine();
            try
            {
                //the program reads the record and displays it on the screen
                record = reader.ReadLine();
                while (record != null)
                {
                    if (record.Contains(input))
                    {
                        Console.WriteLine(record);
                    }
                    record = reader.ReadLine();
                }
            }
            finally
            {
                //after the record is done being read, the progam closes
                reader.Close();
                inFile.Close();
            }
            Pause("Press enter to continue:", true);
            displayBig();
        }

                                            //locate record of big record
        static void locateNameBig()
        {
            IEnumerable<string> lines = File.ReadAllLines(@"E:\CIS 207\Garson_D_Assignment6_CA\Garson_D_Assignment6_CA\bin\Debug\BigRecord.txt");


            Console.WriteLine("Enter the grade: ");
            string input = Console.ReadLine().Trim();


            IEnumerable<string> matches = !String.IsNullOrEmpty(input)
                                          ? lines.Where(line => line.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                                          : Enumerable.Empty<string>();


            Console.WriteLine(matches.Any()
                              ? String.Format("Matches:\n> {0}", String.Join("\n> ", matches))
                              : "There were no matching grades");
            Pause("Press enter to continue:", true);
            displayBig();
        }
                                                //sort method of big record
        static void sortRecordsBig()
        {
                                                //remember to change filepath each different computer use
            StreamReader sr = new StreamReader(@"E:\CIS 207\Garson_D_Assignment6_CA\Garson_D_Assignment6_CA\bin\Debug\BigRecord.txt");

            var names = new List<string>();
            while (!sr.EndOfStream)
            {
                names.Add(sr.ReadLine());
            }

            names.Sort((x, y) => x.Split(',')[0].CompareTo(y.Split(',')[0]));

            foreach (var name in names)
                Console.WriteLine(name);
            Pause("Press enter to continue:", true);
            displayBig();

        }
                            //Pause method used for all methods
        static void Pause(String message, bool status)
        {
            Console.Write(message);
            Console.ReadKey();
            if (status)
            {
                Console.Clear();
            }


        }
                    //exit method used for both big and litle records
        static void exit()
        {

            Environment.Exit(0);

        }




    }
}
