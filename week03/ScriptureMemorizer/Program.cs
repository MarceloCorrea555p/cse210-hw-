using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.ComponentModel;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        string response;
        int startVerse =0;
        int endVerse=0;
        string displaytext;
        bool completel = true;

        Console.WriteLine("Enter the name of the book:");
        Console.Write("> ");
        string bookName = Console.ReadLine();

        Console.WriteLine("enter the chapter:");
        Console.Write("> ");
        int myChapter = int.Parse(Console.ReadLine());

        Console.WriteLine("If the writing has more than one verticle, write yes; otherwise, write no.");
        Console.Write("> ");
        string yesOrno = Console.ReadLine();

        
        if (yesOrno.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("What is the first verse?");
            Console.Write("> ");
            startVerse = int.Parse(Console.ReadLine());
            
            Console.WriteLine("What is the final verse?");
            Console.Write("> ");
            endVerse = int.Parse(Console.ReadLine());
        }


            
        else if (yesOrno.Equals("no", StringComparison.OrdinalIgnoreCase))
        {
            // is "no"
            Console.WriteLine("What is the first verse?");
            Console.Write("> ");
            startVerse = int.Parse(Console.ReadLine());
        }
        else
        {
            // It is neither "yes" nor "no"
            Console.WriteLine("Entrada no válida.");
        }


        Reference myReference = new Reference(bookName, myChapter, startVerse, endVerse);
        string final = myReference.GetDisplayText();
        Console.WriteLine($"{final}");

        Console.WriteLine("enter the content of the Escripture");
        Console.Write("> ");
        string mytext = Console.ReadLine();

        Scripture myScripture = new Scripture(myReference, mytext);
        
        Console.Clear();
        do
        {
            
            Console.WriteLine($"{final}");
            displaytext = myScripture.GetDisplayText();
            Console.Write($"{displaytext}\n\n");

            
                       
            Console.WriteLine("Press enter to continue or type quit to finish");
            response = Console.ReadLine();
             myScripture.HideRandomWords();
             Console.Clear();
             completel = myScripture.IsCompletelyHidden();
          
         } while (response != "quit" && completel != true);

     
    }
}