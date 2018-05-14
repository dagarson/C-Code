/* Daniel Garson
 *  CIS 237
 *  Due 2/21/18
 */

//May the Force be with you.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        //droid collection array
        Droid[] DCollection;

        //droid collection length
        int DCLength;


        // collect into an array
        public DroidCollection(int Arraysize)
        {
            DCollection = new Droid[Arraysize];
            DCLength = 0;
        }



        // adds a new droid to droid collections 
        public void Add(Droid NDroid)
        {
            DCollection[DCLength] = NDroid;
            //increment length 
            DCLength++;
        }



        public string[] DisplayItems()
        {
            //get all items to string 
            string[] all = new string[DCLength];
            int i = 0;

            if (DCLength > 0)
            {
                foreach (Droid droid in DCollection)
                {
                    if (droid != null)
                    {
                        all[i] = droid.ToString();
                        i++;
                    }
                }
            }
            return all;
        }



        //displays all droids
        public void DisplayDroids(string[] Output)
        {
            Console.WriteLine();
            foreach (string itemOutput in Output)
            {
                Console.WriteLine(itemOutput);
            }

        }
    }

}