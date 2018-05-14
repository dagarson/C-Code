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

    //Abstract class that implements the IDroid interface
    abstract class Droid : IDroid
    {
        public string material;
        public string model;
        public string color;


        //Calculation variables
        public string cost;
        public decimal MCost = 0;
        public decimal ModelCost = 0;
        public decimal baseCost;
        public decimal totalCost;




        public virtual decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //Costructor to set material, model, and color costs
        public Droid(string Material, string Model, string Color)
        {
            model = Model;
            material = Material;
            color = Color;

            //Models
            if (model == "Protocol")
                ModelCost = 2000;
            if (model == "Utility")
                ModelCost = 1500;
            if (model == "Janitor")
                ModelCost = 1000;
            if (model == "Astromech")
                ModelCost = 500;

            //materials
            if (material == "Fiberglass")
                MCost = 300;
            if (material == "Steel")
                MCost = 400;
            if (material == "Wood")
                MCost = 100;
            if (material == "Plastic")
                MCost = 50;


            //price of color removed

        }

        //get base cost based on all selections      
        public virtual void CalculateBaseCost()
        {
            baseCost = MCost + ModelCost;
        }

        //total cost  
        public virtual void CalculateTotalCost()
        {
            totalCost += baseCost;
        }


        // returns formatted ToString
        public override string ToString()
        {
            return Material + " " + Model + " " + Color;
        }


        //CampareTo inheriting from IComparable
        public int CompareTo(object obj)
        {
            Droid otherD = (Droid)obj;
            decimal TCost = TotalCost;
            decimal otherTCost = otherD.TotalCost;
            return TCost.CompareTo(otherTCost);
        }


    }
}






