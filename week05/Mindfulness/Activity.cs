using System;
using System.Threading;

public class Activity
{
    // Variables miembro protegidas para que la clase hija pueda leerlas si lo necesita
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear(); // Limpia la pantalla para iniciar ordenado
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");

        ShowSpinner();
        Console.WriteLine();

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.\n");
        ShowSpinner();
        Console.WriteLine();
        
    }

    public void ShowSpinner()
    {
        string[] animacion = { "/", "-", "\\", "|" };
        int contador = 0;

        // Bucle modificado: 50 iteraciones a 100ms durará exactamente 5 segundos
        while (contador < 15) 
        {
            string simbolo = animacion[contador % 4];
            Console.Write(simbolo);

            Thread.Sleep(100);

            // CORRECCIÓN AQUÍ: \b regresa el cursor, el espacio borra el símbolo anterior, y el otro \b vuelve a regresar el cursor
            Console.Write("\b \b"); 
            contador++;
        }
    }

    public void ShowCountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }
        Console.WriteLine();
    }
}
