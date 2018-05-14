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
    //Class to handle all of the User Interface operations
    class UserInterface
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

        public UserInterface()
        {
            //calls method with dummy data and adds it to the printed list
            DummyDroids();
        }

        //main menu used to start the program
        public void StartMenu()
        {

            while (DSelect != 1 || DSelect != 2 || DSelect != 3 || DSelect != 4 || DSelect != 5)
            {
                Console.WriteLine("Project # 3");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1 - Add a Droid");
                Console.WriteLine("2 - Sort Droids by Model");
                Console.WriteLine("3 - Sort Droids by Total Cost");
                Console.WriteLine("4 - Print List of droids");
                Console.WriteLine("5 - Exit");
                Console.Write("");

                try
                {
                    DSelect = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    //adds droid 
                    if (DSelect == 1)
                        AddDroid();

                    //sorts droids by model
                    if (DSelect == 2)
                        try
                        {   //calls bucketsort 
                            droidCollection.BucketSort();
                            Console.WriteLine("Droids sorted by Model Press 4 to view list");
                            Console.WriteLine();
                        }
                        catch
                        {
                            //catch errors
                            Console.WriteLine("Error Sort failed");
                        }

                    //sorts droids by price
                    if (DSelect == 3)
                        try
                        {
                            //calls merge sort
                            droidCollection.MergeSort();
                            Console.WriteLine("Droids sorted by Price Press 4 to view lsit");
                            Console.WriteLine();
                        }
                        catch
                        {
                            //catch errors
                            Console.WriteLine("Error Sort failed");
                        }

                    //prints list of droids
                    if (DSelect == 4)
                        PrintList();

                    //exits program 
                    if (DSelect == 5)
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
            Droid newProtocol = new ProtocolDroid(materailSelect, "Protocol", colorSelect, numLangauges);
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
            Droid newUtility = new UtilityDroid(materailSelect, "Utility", colorSelect, toolBox, computerConnection, arm);
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
            Droid newJanitor = new JanitorDroid(materailSelect, "Janitor", colorSelect, toolBox, computerConnection, arm, trashCompactor, vacuum);
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
            Droid newAstromech = new AstromechDroid(materailSelect, "Astromech", colorSelect, toolBox, computerConnection, arm, fireExtinquisher, numberShips);
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

        //adds dummy hardcoded droids
        //decided to shuffle the order of droids for testing 
        public void DummyDroids()
        {
            //variables for dummy droid #1
            string material1 = "Steel";
            string color1 = "Blue";
            int language1 = 2;

            //dummy Protocol #1
            Droid dumbProtocol1 = new ProtocolDroid(material1, "Protocol", color1, language1);
            droidCollection.Add(dumbProtocol1);
            dumbProtocol1.CalculateBaseCost();
            dumbProtocol1.CalculateTotalCost();
            totalCost += dumbProtocol1.totalCost;


            //variables for dummy droid #3
            string material3 = "Fiberglass";
            string color3 = "White";
            bool dumbTool1 = true;
            bool dumbComputer1 = false;
            bool dumbArm1 = true;
            bool dumbFire1 = true;
            int dumbShip1 = 150;

            //dummy Astromech #1
            Droid dumbAstromech1 = new AstromechDroid(material3, "Astromech", color3, dumbTool1, dumbComputer1, dumbArm1, dumbFire1, dumbShip1);
            droidCollection.Add(dumbAstromech1);
            dumbAstromech1.CalculateBaseCost();
            dumbAstromech1.CalculateTotalCost();
            totalCost += dumbAstromech1.totalCost;


            //variables for dummy droid #2
            string material2 = "Wood";
            string color2 = "Red";
            int language2 = 20;

            //dummy Protocol #2
            Droid dumbProtocol2 = new ProtocolDroid(material2, "Protocol", color2, language2);
            droidCollection.Add(dumbProtocol2);
            dumbProtocol2.CalculateBaseCost();
            dumbProtocol2.CalculateTotalCost();
            totalCost += dumbProtocol2.totalCost;

            //variables for dummy droid #5
            string material5 = "Steel";
            string color5 = "Red";
            bool dumbTool3 = true;
            bool dumbComputer3 = true;
            bool dumbArm3 = true;

            //dummy Utility #1
            Droid dumbUtility1 = new UtilityDroid(material5, "Utility", color5, dumbTool3, dumbComputer3, dumbArm3);
            droidCollection.Add(dumbUtility1);
            dumbUtility1.CalculateBaseCost();
            dumbUtility1.CalculateTotalCost();
            totalCost += dumbUtility1.totalCost;


            //variables for dummy droid #4
            string material4 = "Plastic";
            string color4 = "Gold";
            bool dumbTool2 = false;
            bool dumbComputer2 = false;
            bool dumbArm2 = false;
            bool dumbFire2 = false;
            int dumbShip2 = 4;

            //dummy Astromech #2
            Droid dumbAstromech2 = new AstromechDroid(material4, "Astromech", color4, dumbTool2, dumbComputer2, dumbArm2, dumbFire2, dumbShip2);
            droidCollection.Add(dumbAstromech2);
            dumbAstromech2.CalculateBaseCost();
            dumbAstromech2.CalculateTotalCost();
            totalCost += dumbAstromech2.totalCost;

            //variables for dummy droid #8
            string material8 = "Steel";
            string color8 = "Red";
            bool dumbTool6 = true;
            bool dumbComputer6 = true;
            bool dumbArm6 = true;
            bool dumbTrash2 = true;
            bool dumbVacuum2 = true;

            //dummy Janitor #2
            Droid dumbJanitor2 = new JanitorDroid(material8, "Janitor", color8, dumbTool6, dumbComputer6, dumbArm6, dumbTrash2, dumbVacuum2);
            droidCollection.Add(dumbJanitor2);
            dumbJanitor2.CalculateBaseCost();
            dumbJanitor2.CalculateTotalCost();
            totalCost += dumbJanitor2.totalCost;


            //variables for dummy droid #6
            string material6 = "Steel";
            string color6 = "Black";
            bool dumbTool4 = true;
            bool dumbComputer4 = false;
            bool dumbArm4 = false;

            //dummy Utility #2
            Droid dumbUtility2 = new UtilityDroid(material6, "Utility", color6, dumbTool4, dumbComputer4, dumbArm4);
            droidCollection.Add(dumbUtility2);
            dumbUtility2.CalculateBaseCost();
            dumbUtility2.CalculateTotalCost();
            totalCost += dumbUtility2.totalCost;


            //variables for dummy droid #7
            string material7 = "Wood";
            string color7 = "Blue";
            bool dumbTool5 = false;
            bool dumbComputer5 = true;
            bool dumbArm5 = true;
            bool dumbTrash1 = true;
            bool dumbVacuum1 = false;

            //dummy Janitor #1
            Droid dumbJanitor1 = new JanitorDroid(material7, "Janitor", color7, dumbTool5, dumbComputer5, dumbArm5, dumbTrash1, dumbVacuum1);
            droidCollection.Add(dumbJanitor1);
            dumbJanitor1.CalculateBaseCost();
            dumbJanitor1.CalculateTotalCost();
            totalCost += dumbJanitor1.totalCost;


           

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








