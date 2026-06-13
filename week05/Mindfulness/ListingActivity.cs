using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
       private int _count;
    private List<string> _prompts;


    public ListingActivity(): base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Run();
    }

    
    public void Run()
    {
        
        DisplayStartingMessage();

        
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner();
        Console.WriteLine();

        
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[index]} ---");
        Console.Write("You may begin in: ");
        
        // 4. Cuenta regresiva de la clase padre antes de escribir
        ShowCountDown();
        Console.WriteLine();

        // Lista local para almacenar temporalmente las respuestas del usuario
        List<string> userResponses = new List<string>();

        // 5. Control de tiempo dinámico usando la variable heredada '_duration'
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // El usuario ingresa texto de forma continua mientras el tiempo actual sea menor al de finalización
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            // Validar que no se agreguen entradas vacías si el usuario presiona Enter rápido
            if (!string.IsNullOrEmpty(response))
            {
                userResponses.Add(response);
            }
        }

        // 6. Contabilizar los resultados obtenidos
        _count = userResponses.Count;
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();

        // 7. Mostrar mensaje de finalización heredado del padre
        DisplayEndingMessage();
    }
}
