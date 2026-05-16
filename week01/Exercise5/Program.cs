using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    
    // Method to display a Welcome Message ---------------------------------------
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }


    //  Method to prompt the user for their name --------------------------------
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    
    //  Method to prompt the user for their favorite number -------------------------------- 
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

     //  Method to calculate the square of the number --------------------------------
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    

    //  Method to display the result -----------------------------------------------
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}