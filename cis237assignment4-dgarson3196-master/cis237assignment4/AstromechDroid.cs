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
    //Class that inherits from the Utility Droid
    class AstromechDroid : UtilityDroid
    {
        public bool fireExtinguisher;
        public int numberShips;

        //decisions variables
        public string fireTF;

        //Calculation variables
        public int shipsCost;
        public int fireCost;


        //Constructor which inherits from Utility class, which inherits from Droid class
        public AstromechDroid(string Material, string Model, string Color, bool TB, bool CC, bool A, bool FE, int NS) : base(Material, Model, Color, TB, CC, A)

        {
            //fire extiguisher choice
            fireExtinguisher = FE;
            if (fireExtinguisher)
            {
                fireTF = "Fire Extinguisher";
                fireCost = 50;
            }
            else fireTF = "NO Fire Extinguisher";

            //get number of ships 100 per
            numberShips = NS;
            shipsCost = numberShips * 100;
        }

        //get base cost based on all selections 
        public override void CalculateBaseCost()
        {
            baseCost = ModelCost + MCost + toolCost + compCost + armCost + fireCost + shipsCost;
            cost = baseCost.ToString();
        }

        public override void CalculateTotalCost()
        {
            base.totalCost += baseCost;
        }

        // returns formatted ToString
        public override string ToString()
        {
            return Model + " | " + Material + " | " + Color + Environment.NewLine + toolTF + " | " + connectionTF + " | " + armTF + " | " +
                //Add separation for printed list
                fireTF + Environment.NewLine + "Number of ships " + numberShips.ToString() + Environment.NewLine + "Subtotal $" + cost + Environment.NewLine + "______________________";
        }



    }
}
