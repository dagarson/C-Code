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
    class Janitorial : Utility
    {
        //Variables
        public bool trashCompactor;
        public bool vacuum;

        //decisions variables
        public string trashTF;
        public string vacuumTF;

        //Calculation variables
        public int trashCost = 0;
        public int vacuumCost = 0;

        //Constructor 
        public Janitorial(string Material, string Model, string Color, bool TB, bool CC, bool A, bool Compactor, bool Vacuum) : base(Material, Model, Color, TB, CC, A)
        {

            //trash compactor choice
            trashCompactor = Compactor;
            if (trashCompactor)
            {
                trashTF = "Trash Compactor";
                trashCost = 50;
            }
            else trashTF = "NO Trash Compactor";

            //vacuum choice
            vacuum = Vacuum;
            if (vacuum)
            {
                vacuumTF = "Vacuum";
                vacuumCost = 50;
            }
            else vacuumTF = "NO Vacuum";


        }

        //get base cost based on all selections 
        public override void CalculateBaseCost()
        {
            baseCost = MCost + ModelCost + toolCost + compCost + armCost + trashCost + vacuumCost;
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
                trashTF + " | " + vacuumTF + Environment.NewLine + "Subtotal $" + cost + Environment.NewLine + "______________________";
        }


    }
}