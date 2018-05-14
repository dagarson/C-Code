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
    class CSVProcessor
    { 
        public static void processLine(string line, WineItem[] Winelist, int i)
        {

            string[] elements = line.Split(',');

            string id = elements[0];
            string type = elements[1];
            string ammount = elements[2];

            Winelist[i] = new WineItem(id, type, ammount);
          



        }

      

        }

        
      
    }



