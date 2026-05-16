using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int secretNumber = randomGenerator.Next(1, 101);
        int guess = 0;

         
       
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
          

            if (secretNumber > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (secretNumber < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (guess != secretNumber);           
    }
}