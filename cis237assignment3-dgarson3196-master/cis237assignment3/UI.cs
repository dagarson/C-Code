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
    class UI
    {
        // Droid Selection Variables takes user input
        //which makes all selections 
        private int DSelect;

        //Protocol Selection Variables
        private int numLangauges;

        //Utility Selection Variables
        private bool toolBox;
        private bool computerConnection;
        private bool arm;

        //Janitor Selection Variables
        private bool trashCompactor;
        private bool vacuum;

        //Astromech Selection Variables
        private int numberShips = 0;
        private bool fireExtinquisher;

        //Adding Option Variables
        private string materailSelect;
        private string colorSelect;
        private decimal totalCost = 0;

        DroidCollection droidCollection = new DroidCollection(100);

        public UI()
        {
        }

        //main menu used to start the program
        public void StartMenu()
        {
            while (DSelect != 1 || DSelect != 2 || DSelect != 3)
            {
                Console.WriteLine("Project # 3");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1 - Add a Droid");
                Console.WriteLine("2 - Print list of Droids");
                Console.WriteLine("3 - Exit");
                Console.Write("");
                try
                {
                    DSelect = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    //adds droid 
                    if (DSelect == 1)

                        //Prints a list of droids 
                        AddDroid();
                    if (DSelect == 2)
                        PrintList();

                    //exits program 
                    if (DSelect == 3)
                        Environment.Exit(0);

                }
                //catch invalid input 
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Error: Please make a proper selection");
                }
            }
        }

        public void AddDroid()
        {
            Console.WriteLine("What type of droid would you like to add: ");
            Console.WriteLine("__________________________________________");
            Console.WriteLine("1 - Protocol  = $2000");
            Console.WriteLine("2 - Utility   = $1500");
            Console.WriteLine("3 - Janitor   = $1000");
            Console.WriteLine("4 - Astromech = $500");
            Console.WriteLine("5 - Back to Main Menu");
            Console.WriteLine("6 - Exit");
            Console.Write("");

            try
            {
                DSelect = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //add appropiate droid based on selection
                if (DSelect == 1)
                    AddP();
                if (DSelect == 2)
                    AddU();
                if (DSelect == 3)
                    AddJ();
                if (DSelect == 4)
                    AddA();
                if (DSelect == 5)
                    StartMenu();
                if (DSelect == 6)
                    Environment.Exit(0);

            }
            //catch invalid input 
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Error: Please make a proper selection");
            }
        }

        //add Protocol
        public void AddP()
        {
            Dptions("Protocol");
            Console.WriteLine("==========================================================================");
            Droid newProtocol = new Protocol(materailSelect, "Protocol", colorSelect, numLangauges);
            droidCollection.Add(newProtocol);
            newProtocol.CalculateBaseCost();
            newProtocol.CalculateTotalCost();
            totalCost += newProtocol.totalCost;
            Console.WriteLine("COLLECTED: " + newProtocol);
            Console.WriteLine("==========================================================================");
            Console.WriteLine();

        }

        //add Utility
        public void AddU()
        {
            Dptions("Utility");
            Console.WriteLine("==========================================================================");
            Droid newUtility = new Utility(materailSelect, "Utility", colorSelect, toolBox, computerConnection, arm);
            droidCollection.Add(newUtility);
            newUtility.CalculateBaseCost();
            newUtility.CalculateTotalCost();
            totalCost += newUtility.totalCost;
            Console.WriteLine("COLLECTED: " + newUtility);
            Console.WriteLine("==========================================================================");
            Console.WriteLine();



        }

        //add Janitor
        public void AddJ()
        {
            Dptions("Janitor");

            Console.WriteLine("==========================================================================");
            Droid newJanitor = new Janitorial(materailSelect, "Janitor", colorSelect, toolBox, computerConnection, arm, trashCompactor, vacuum);
            droidCollection.Add(newJanitor);
            newJanitor.CalculateBaseCost();
            newJanitor.CalculateTotalCost();
            totalCost += newJanitor.totalCost;
            Console.WriteLine("COLLECTED: " + newJanitor);
            Console.WriteLine("==========================================================================");
            Console.WriteLine();


        }


        //add Astromech
        public void AddA()
        {
            Dptions("Astromech");

            Console.WriteLine("==========================================================================");
            Droid newAstromech = new Astromech(materailSelect, "Astromech", colorSelect, toolBox, computerConnection, arm, fireExtinquisher, numberShips);
            droidCollection.Add(newAstromech);
            newAstromech.CalculateBaseCost();
            newAstromech.CalculateTotalCost();
            totalCost += newAstromech.totalCost;
            Console.WriteLine("COLLECTED: " + newAstromech);
            Console.WriteLine("==========================================================================");
            Console.WriteLine();




        }


        public void Dptions(string Model)
        {

            Console.WriteLine("Select Material");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1 - Fiberglass  = $300");
            Console.WriteLine("2 - Steel = $400");
            Console.WriteLine("3 - Wood = $100 ");
            Console.WriteLine("4 - Plastic = $50 ");

            Console.Write("");
            try
            {
                DSelect = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (DSelect == 1)
                    materailSelect = "Fiberglass";

                if (DSelect == 2)
                    materailSelect = "Steel";
                if (DSelect == 3)
                    materailSelect = "Wood";
                if (DSelect == 4)
                    materailSelect = "Plastic";


            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Error: Please make a proper selection");
            }

            Console.WriteLine("Select Color");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1 - White");
            Console.WriteLine("2 - Black");
            Console.WriteLine("3 - Blue");
            Console.WriteLine("4 - Red");
            Console.WriteLine("5 - Gold");

            Console.Write("");

            try
            {
                DSelect = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (DSelect == 1)
                    colorSelect = "White";

                if (DSelect == 2)
                    colorSelect = "Black";
                if (DSelect == 3)
                    colorSelect = "Blue";
                if (DSelect == 4)
                    colorSelect = "Red";
                if (DSelect == 5)
                    colorSelect = "Gold";


            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Error: Please make a proper selection");
            }

            if (Model == "Protocol")
            {

                Console.WriteLine("Enter the number of languages($50 per language)");
                numLangauges = int.Parse(Console.ReadLine());

            }

            if (Model == "Utility" || Model == "Janitor" || Model == "Astromech")
            {

                Console.WriteLine("Would you like to add a Toolbox?");
                Console.WriteLine("1 - Yes = $50");
                Console.WriteLine("2 - No ");
                Console.Write("");

                DSelect = int.Parse(Console.ReadLine());
                if (DSelect == 1)
                    toolBox = true;
                if (DSelect == 2)
                    toolBox = false;

                Console.WriteLine();


                Console.WriteLine("Would you like to add a Computer Connection?");
                Console.WriteLine("1 - Yes = $50");
                Console.WriteLine("2 - No ");
                Console.Write("");

                DSelect = int.Parse(Console.ReadLine());
                if (DSelect == 1)
                    computerConnection = true;
                if (DSelect == 2)
                    computerConnection = false;

                Console.WriteLine();


                Console.WriteLine("Would you like to add a Arm?");
                Console.WriteLine("1 - Yes = $50");
                Console.WriteLine("2 - No ");
                Console.Write("");


                DSelect = int.Parse(Console.ReadLine());
                if (DSelect == 1)
                    arm = true;
                if (DSelect == 2)
                    arm = false;

                Console.WriteLine();
            }

            if (Model == "Janitor")
            {

                Console.WriteLine("Would you like to add a Trash Compactor?");
                Console.WriteLine("1 - Yes = $50");
                Console.WriteLine("2 - No ");
                Console.Write("");

                DSelect = int.Parse(Console.ReadLine());
                if (DSelect == 1)
                    trashCompactor = true;
                if (DSelect == 2)
                    trashCompactor = false;

                Console.WriteLine();

                Console.WriteLine("Would you like to add a Vacuum?");
                Console.WriteLine("1 - Yes = $50");
                Console.WriteLine("2 - No");
                Console.Write("");

                DSelect = int.Parse(Console.ReadLine());
                if (DSelect == 1)
                    vacuum = true;
                if (DSelect == 2)
                    vacuum = false;


                Console.WriteLine();
            }

            if (Model == "Astromech")
            {
                Console.WriteLine("Would you like to add a Fire Extinguisher?");
                Console.WriteLine("1 - Yes = $50");
                Console.WriteLine("2 - No");
                Console.Write("");

                DSelect = int.Parse(Console.ReadLine());
                if (DSelect == 1)
                    fireExtinquisher = true;
                if (DSelect == 2)
                    fireExtinquisher = false;


                Console.WriteLine();

                Console.Write("Enter the number of Ships($100 per Ship) ");
                numberShips = int.Parse(Console.ReadLine());


                Console.WriteLine();
            }

        }

        public void PrintList()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("                  Droid List");
            Console.WriteLine("-------------------------------------------------");

            string[] allDroids = droidCollection.DisplayItems();
            droidCollection.DisplayDroids(allDroids);

            Console.WriteLine("Total = $" + totalCost);
            Console.WriteLine("______________________");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.WriteLine();
            Console.ReadKey();

        }

    }
}
