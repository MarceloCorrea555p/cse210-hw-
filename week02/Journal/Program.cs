/*--------------------------------------------------------------------------
          Showing Creativity and Exceeding Requirements
    Improve the process of saving and loading to save as a .csv file that could be opened
     in Excel (make sure to account for quotation marks and commas correctly in your content. 
     
     Two more options have been added to the list of options. Option 6 downloads the data from 
     the "journalNew.csv" file. To do this, call the LoadFromFile() method located in the Journal 
     class. Option 7 saves the user-entered data to the "journalNew.csv" document. This is done by 
     calling the AddEnCsv() method located in the Journal class.

     In the Entry class, methods are added that convert the entered data to the format csv
     */   


using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal myJournal = new Journal();  // Crear instancia
        int response;
        
       

        //Journal myjournal = new Journal(); 
        
        do
        {
            Console.WriteLine("Please select one of the following choices ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Load CSV file.");
            Console.WriteLine("7. Save CSV file.");
            Console.Write("What would you like to do? ");
            response = int.Parse(Console.ReadLine());
            
            if (response == 1) 
            {
                myJournal.AddEntry(); //enter user text
                          
                response = 5;

            }

            else if (response == 2)
            {
                 myJournal.DisplayAll();

                 response = 5;
            }

            else if (response == 3)
            {
                Console.WriteLine("What is the filename?");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                //myJournal.GuardarEnCsv();
                myJournal.LoadFromFile(fileName);
                response = 5;
            }

            else if (response == 4)
            {
                Console.WriteLine("What is the filename?");
                Console.Write("> ");
                string fileName = Console.ReadLine();

                myJournal.SaveFile(fileName);
                response = 5;
            }
            else if (response == 5)
            {
                response = 0;
            }
           
            else if (response == 6)
            {
                myJournal.LoadFromCsv();
                response = 5;

            }
            else if (response == 7)
            {
                
                myJournal.AddEnCsv();
                response = 5;

            }
             else
            {
                Console.WriteLine("Invalid option, enter a number from 1 to 5.");
                response = 5;
            }



        } while (response == 5);

    }
}
