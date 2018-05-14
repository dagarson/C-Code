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
    class WineItemCollection
    {



        public void WineCSV(string CSVFile, WineItem[] Winelist)
        {

            StreamReader streamreader = null;

            try
            {
                string line;

               
                streamreader = new StreamReader(CSVFile);


                int i = 0;


                while ((line = streamreader.ReadLine()) != null)
                {
                    CSVProcessor.processLine(line, Winelist, i++);

                }


            }


            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                if (streamreader != null)
                {
                    streamreader.Close();


                }
            }
        }
         public void ArrayLoaded()
        {
            if (Program.ProcessArrayExecuted == true)
            {
                Console.WriteLine("File Loaded");
            }

            else
            {
                Console.WriteLine("File not Loaded");
            }



        }

    

        public void Search()
        {
            FileStream inFile = new FileStream("../../../datafiles/WineList.csv", FileMode.Open, FileAccess.Read);
            StreamReader locate = new StreamReader(inFile);
            string record;
            string input;
            Console.Write("Enter the ID ");
           
            input = Console.ReadLine().ToUpper();
            try
            {

                record = locate.ReadLine();
                while (record != null)
                {
                    if (record.Contains(input))
                    {
                        Console.WriteLine(record);
                        Console.WriteLine("");
                    }
                    record = locate.ReadLine();
                }
            }
            finally
            {

                locate.Close();
                inFile.Close();
            }
        }

        // Display to user if file was updated
        public void Add()
        {
            if (Program.Added == true)
            {
                Console.WriteLine("WineList Updated");
            }

            else
            {
                Console.WriteLine("WineList Not Updated");
            }



        }


    }
}

