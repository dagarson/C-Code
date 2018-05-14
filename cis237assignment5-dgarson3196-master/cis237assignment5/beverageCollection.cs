/*Author: Daniel Garson
CIS 237
Assignment 5
Due: 4-2-18
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment5
{
    class beverageCollection
    {
        public BeveragesDBContext beverage;
        public beverageCollection()
        {
            beverage = new BeveragesDBContext();
        }

        //print full list
        public void printBev()
        {
            Console.WriteLine();
            foreach (Beverage printBeverage in beverage.Beverages)
            {                      //use tostring for formating
                Console.WriteLine(printBeverage.ToString());                //used to seperate record for easier viewing
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
            }
            Console.ReadLine();
        }
        //search for record
        public void search()
        {
            string sString;

            Console.Write("Enter Wine ID: ");
            try
            {
                // search for an beverage by ID using ".Where"
                sString = Console.ReadLine();
                Console.WriteLine();
                Beverage beverageToFind = beverage.Beverages.Where(c => c.id == sString).First();
                //Output beverage if found
                Console.WriteLine("ID: " + beverageToFind.id + " Matches to " + Environment.NewLine + "Name: " + beverageToFind.name +Environment.NewLine+"Pack: "+ beverageToFind.pack
                    + Environment.NewLine + "Price: " + beverageToFind.price + Environment.NewLine + "Active: " +beverageToFind.active); 
                Console.WriteLine();
            }
            catch
            {
                //Error if no beverage found
                Console.WriteLine("Error - Beverage Not Found"); 
            }
        }

        //add a beverage 
        public void addBev()
        {
            //clear console for easier viewing
            Console.Clear();
            //Create new beverage instance 
            Beverage newBevToAdd = new Beverage(); 
            try
            { 
                //Adds new Beverage ID
                Console.Write("Enter Beverages ID: ");       
                newBevToAdd.id = Console.ReadLine();

                //Adds new Beverage Name
                Console.Write("Enter Beverages Name: ");      
                newBevToAdd.name = Console.ReadLine();

                //Adds new Beverage Pack
                Console.Write("Enter Beverages Pack: ");      
                newBevToAdd.pack = Console.ReadLine();

                 //Adds new Beverage Price
                Console.Write("Enter Beverages Price: ");    
                newBevToAdd.price = int.Parse(Console.ReadLine());

               //add active
                Console.WriteLine("Enter Beverages active status type yes for TRUE or no for FALSE)");
                string active = Console.ReadLine();

                //if type yes active = true
                if (active.ToLower() == "yes")
                {
                    newBevToAdd.active = true;

                }

                //if type no active = true
                else if (active.ToLower() == "no")
                {
                    newBevToAdd.active = false;

                }

               

                Console.WriteLine();

                //Beverage is added to collection using ".Add"
                beverage.Beverages.Add(newBevToAdd); 

                //Save changes 
                beverage.SaveChanges();             
                Console.WriteLine("Wine Add Successful");
                Console.WriteLine();
            }

            catch
            {   //Error message  ID already exists in collection, or if input is bad
                Console.WriteLine();
                Console.WriteLine("Error - Beverage not added");
                Console.WriteLine();
            }



        }

        //delete beverage 
        public void deleteBev()
        {

            //variable for delete selection
            int delSelect;


            Console.WriteLine("Enter ID to delete record or press Enter to return to menu: ");

            //Try Catch  handles bad input
            try
            {   //Create a new beverage instance based on input ID
                Beverage bevToDelete = beverage.Beverages.Find(Console.ReadLine()); 
                Console.WriteLine();

                //show matching records ID and Name
                Console.WriteLine("Beverage to Delete");
                Console.WriteLine("------------------------");
                Console.WriteLine("ID: " + bevToDelete.id);
                Console.WriteLine("Name: " + bevToDelete.name);
                Console.WriteLine();

              // prompt user to make sure they want to delete this record
                Console.WriteLine("Is this record correct?");
                Console.WriteLine();

                //continue deleting
                Console.WriteLine("1-Yes");
                
                //go back if wrong record
                Console.WriteLine("2-No, Go Back");
                Console.WriteLine();


                try
                {
                    delSelect = int.Parse(Console.ReadLine());
                    Console.WriteLine();


                    //If user presses 1 the record will be deleted 
                    if (delSelect == 1)
                    {
                        
                        beverage.Beverages.Remove(bevToDelete);

                        //display sucessful delete
                        Console.WriteLine("Delete Successful");  
                        Console.WriteLine();

                    }
                    //if user selects 2 the main menu will redisplay
                    if (delSelect == 2)

                        UserInterface.mainMenu();                        


              


                }

             //Error message if didnt type 1 or 2
                catch
                {
                 

                    Console.WriteLine("Error invaild input");
                    Console.WriteLine();
                }

            }
        //Error message if No beverage matches to id 
            catch
            {
                
                Console.WriteLine("Error no Beverage found");
                Console.WriteLine();
            }
            //save changes
            beverage.SaveChanges();
        }




        // update a beverage 
        public void updateBev()
        {
            //variable for update selection
            int upSelect;


            Console.Write("Enter Wine ID To Update: ");
            try
            {
                //Create new beverage instance 
                Beverage bevToUpdate = beverage.Beverages.Find(Console.ReadLine()); 
                Console.WriteLine();

                //variable for delete selection
                Console.WriteLine("Wine To Update: ");
                Console.WriteLine("-----------------------");
                Console.WriteLine("ID: " + bevToUpdate.id);
                Console.WriteLine("Name: " + bevToUpdate.name);
                Console.WriteLine();

                // prompt user to make sure they want to delete this record
                Console.WriteLine("Correct Wine To Update?");
                Console.WriteLine();

                //continue update
                Console.WriteLine("1: Yes");

                //go back wrong id
                Console.WriteLine("2: No, Go Back"); 
                
                //return to main menue            
                Console.WriteLine("3: Exit To Main Menu");      
                Console.WriteLine();

                //Try Catch  handles bad input
                try
                {   
                    upSelect = int.Parse(Console.ReadLine());
                    Console.WriteLine();
               


                    if (upSelect == 1)
                    {
                        try
                        {   
                            //enter new name for Beverage
                            Console.Write("Enter New Wine Name: ");
                            bevToUpdate.name = Console.ReadLine();
                            Console.WriteLine();

                            //enter new pack for Beverage
                            Console.Write("Enter New Wine Pack: ");
                            bevToUpdate.pack = Console.ReadLine();
                            Console.WriteLine();

                            //enter new price for Beverage
                            Console.Write("Enter New Wine Price: ");
                            bevToUpdate.price = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            //enter new active status  for Beverage
                            Console.WriteLine("Enter a new active status for the beverage: (Yes or no)");

                            string active = Console.ReadLine();

                            //if type yes active = true
                            if (active.ToLower() == "yes")
                            {

                                bevToUpdate.active = true;

                            }

                            //if type no active = false
                            else if (active.ToLower() == "no")
                            {

                                bevToUpdate.active = false;

                            }

                            // if they typed anything but yes or no
                            else
                            {
                                Console.WriteLine(active + " is not a valid input please only type yes or no");
                                Console.WriteLine("Press ENTER to restart the update and try again");
                                Console.ReadLine();
                                updateBev();
                            }
                            //display sucessful update
                            Console.WriteLine("Wine Update Successful");
                            Console.WriteLine();

                        }

                        //catch bad input 
                        catch
                        {
                            Console.WriteLine("Bad Input - Wine Update Unsuccessful");
                          
                        }

                    }

                    //if type 2 start pocess over again
                    if (upSelect == 2)
                        updateBev();        

                    //if type 3 go back to main menu
                    if (upSelect == 3)
                        UserInterface.mainMenu();            
                  
                }

                //Error message if no beverage found
                catch
                {
                    
                    Console.WriteLine("Error - beverage not found please try again");
                    updateBev();
                }

             //Save changes
                beverage.SaveChanges();  

            }

            //catch any general errors in the process return user to menu
            catch
            {
                Console.WriteLine("Error occured Press ENTER to returning to menu");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}




