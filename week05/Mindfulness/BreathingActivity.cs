using System;
using System.Threading;

public class BreathingActivity : Activity
{
    // Constructor correcto que inicializa la clase padre
    public BreathingActivity(): base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        Run();
    }

    

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready to begin...");
                   
        ShowSpinner(); 
        Console.WriteLine("\n");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
        
            ShowCountDown(); 
            
            Console.Write("Breathe out... ");
            ShowCountDown();
            
            Console.WriteLine();
        }
        DisplayEndingMessage();
        

        
    }

}
