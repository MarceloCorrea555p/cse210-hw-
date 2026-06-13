using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string choice;



        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Breathing Activity");
            Console.WriteLine("    2. Reflection Activity");
            Console.WriteLine("    3. Listing Activity");
            Console.WriteLine("    4. Exit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            
            //  Breathing Activity
            if (choice == "1")
            {
               BreathingActivity breathingActivity = new BreathingActivity();
                                               
            }
            
            //Reflection Activity
            else if (choice == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
            }    
                            
            // Listing Activity
            else if (choice == "3")
            {
            ListingActivity listingActivity = new ListingActivity();
              
            }

            // Exit
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option from the menu.");
            }

        } while (choice != "4");

    }
}