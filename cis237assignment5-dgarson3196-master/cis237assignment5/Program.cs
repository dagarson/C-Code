/*Author: Daniel Garson
CIS 237
Assignment 5
Due: 4-2-18
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            // resize the console for easier viewing
            Console.WindowWidth = 100;
            Console.WindowHeight = 30;

            //instanciating bev collection
            beverageCollection bCollection = new beverageCollection();

            Console.SetBufferSize(4000, Int16.MaxValue - 1);
            int userinput = UserInterface.validateSelect();

            while (userinput != 6)
            {
                switch (userinput)
                {
                    //used to print list
                    case 1:
                        {
                            bCollection.printBev();
                            break;
                        }

                        //used to search
                    case 2:
                        {
                            Console.Clear();


                            bCollection.search();
                            break;
                        }

                        //used to add to database
                    case 3:
                        {
                            bCollection.addBev();
                            break;
                        }

                        //used to update record
                    case 4:
                        {
                            bCollection.updateBev();
                            break;
                        }

                        //used to delete record
                    case 5:
                        {
                            bCollection.deleteBev();
                            break;
                        }

                }
                //validate selection
                userinput = UserInterface.validateSelect();
            }
            //exit program
            Environment.Exit(0);
        }
    }
}
