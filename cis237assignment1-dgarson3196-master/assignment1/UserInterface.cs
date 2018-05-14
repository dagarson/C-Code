/* Daniel Garson
 * CIS 237
 * 1/24/18
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
       static public int GetUserInput()
        {
          
           Menu();

            
            String input = Console.ReadLine();

          
            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                Error();

                Menu();

               
                input = Console.ReadLine();


            }
            return Int32.Parse(input);


        }

        static public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }


      static private void Menu()
        {
            Console.WriteLine("Assignment #1");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. To Load the WineItem list");
            Console.WriteLine("2. To display the full list");
            Console.WriteLine("3.To Search for an Item on the list");
            Console.WriteLine("4. To Add to the list");
            Console.WriteLine("5. To Exit");
            Console.WriteLine("-----------------------------------------");

        }

        static private void Error()
        {
            Console.WriteLine("This is not vaild ");
        }
    }
}

