/* Daniel Garson
 * CIS 237 
 * Due: 3/19/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            //resizes window so you can see printed list better
            Console.WindowHeight = 50;

            //call and display UI
            UserInterface Menu = new UserInterface();

            Menu.StartMenu();
        }

    }
}
