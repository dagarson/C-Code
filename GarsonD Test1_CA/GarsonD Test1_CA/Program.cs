/* Daniel Garson
 * Test 1
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarsonD_Test1_CA
{
    
    class Program
    {
        static void Main(string[] args)
        {

            string city;
            string zip;

            Console.WriteLine("Enter City" );
            city = Console.ReadLine();

            Console.WriteLine("Enter Zip Code for " + city + ":");
            zip = Console.ReadLine();

            Console.WriteLine(city + "'s zip code is " + zip);

            Console.WriteLine("Press any key to continue...");

            Console.ReadLine();
        }
    }
}
