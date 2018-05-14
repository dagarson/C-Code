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
    //Class that is instantiable. It inherits from the abstract droid class
    class ProtocolDroid : Droid
    {
        public int numberLanguages;
        const int costPerlanguage = 50;


        public int NumberLanguages
        {
            get { return numberLanguages; }
            set { numberLanguages = value; }
        }


        public ProtocolDroid(string Material, string Model, string Color, int numLanguages)
            : base(Material, Model, Color)
        {
            numberLanguages = numLanguages;
        }

        //get base cost based on all selections 
        public override void CalculateBaseCost()
        {
            baseCost = ModelCost + MCost + (numberLanguages * 50);
            cost = baseCost.ToString();
        }



        public override void CalculateTotalCost()
        {
            base.totalCost += baseCost;

        }


        // returns formatted ToString
        public override string ToString()
        {
            return Model + " | " + Material + " | " + Color + Environment.NewLine + "Number of Languages: " +
                //Add separation for printed list
                numberLanguages + Environment.NewLine + "Subtotal $" + cost + Environment.NewLine + "______________________";
        }


    }
}
