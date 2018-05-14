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
    class Utility : Droid
    {
        //Variables
        public bool toolbox;
        public bool computerConnection;
        public bool arm;

        //decisions variables
        public string toolTF;
        public string connectionTF;
        public string armTF;

        //calcuation variables
        public int toolCost;
        public int compCost;
        public int armCost;

        //Constructor 
        public Utility(string Material, string Model, string Color, bool TB, bool CC, bool A) : base(Material, Model, Color)

        {
            //toolbox choice
            toolbox = TB;
            if (toolbox)
            {
                toolTF = "ToolBox";
                toolCost = 50;

            }
            else toolTF = "NO ToolBox";


            //computer connection choice
            computerConnection = CC;
            if (computerConnection)
            {
                connectionTF = "Computer Connection";
                compCost = 50;
            }
            else connectionTF = "NO Computer Connection";



            //arm choice
            arm = A;
            if (arm)
            {
                armTF = "Arm";
                armCost = 50;
            }
            else armTF = " NO Arm";


        }

        //get base cost based on all selections 
        public override void CalculateBaseCost()
        {
            baseCost = ModelCost + MCost + toolCost + compCost + armCost;
            cost = baseCost.ToString();
        }

        public override void CalculateTotalCost()
        {
            base.totalCost += baseCost;
        }

        // returns formatted ToString
        public override string ToString()
        {
            return Model + " | " + Material + " | " + Color + Environment.NewLine + " | " + toolTF + " | " + connectionTF + " | " + armTF +
                //Add separation for printed list
                Environment.NewLine + "Subtotal $" + cost + Environment.NewLine + "______________________";
        }

    }
}
