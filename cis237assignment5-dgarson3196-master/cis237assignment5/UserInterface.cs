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
    class UserInterface
    {
         // write output to console
        public static void Output(string outputString)                 
        {
            Console.WriteLine(outputString);
        }

            // main menu menu
        public static void mainMenu()                                     
        {
            Console.WriteLine("Assignment #5 Beverage Database");
            Console.WriteLine("________________________________");
            Console.WriteLine("1. Print All Beverages");
            Console.WriteLine("2. Search for Beverage by ID");
            Console.WriteLine("3. Add a Beverage");
            Console.WriteLine("4. Update a Beverage");
            Console.WriteLine("5. Delete a Beverage");
            Console.WriteLine("6. Exit program");
            Console.WriteLine();
        }

        // validate that the user input is a valid number
        public static int validateSelect()                                
        {
            //call main menu
            mainMenu();

            String input = Console.ReadLine();
            // if input is not 1-6 error
            if (input != "1" && input != "2" && input != "3" && input != "4" && input != "5" && input != "6")
            {
                Console.WriteLine("**************************************");
                Console.WriteLine(input + " is not a value menu option try again");
                Console.WriteLine("**************************************");
                Console.WriteLine();
                mainMenu();//recall menue

                input = Console.ReadLine();
            }
            return int.Parse(input);
        }



    }
}
