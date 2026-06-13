using System.Security.Cryptography.X509Certificates;

public class ReflectionActivity : Activity
{

    //member variables or attributes

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?"
    };

    //the methods
        public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
            Run();
        
        }

        public void Run()
        {
             DisplayStartingMessage();
            Console.WriteLine("Get ready to begin...");
                   
            ShowSpinner(); 
            Console.WriteLine("\n");


            Random random = new Random();
            int promptIndex = random.Next(_prompts.Count);
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"--- {_prompts[promptIndex]} ---");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.Write("You may begin in:");
            
            ShowCountDown();

            Console.WriteLine();

            int questionIndex = random.Next(_questions.Count);
            for (int i = 0; i < _duration / 10; i++)
            {
                Console.WriteLine($"--- {_questions[questionIndex]} ---");
                ShowSpinner();
                questionIndex = random.Next(_questions.Count);
                ShowSpinner();
            }

            DisplayEndingMessage();

            
        }

        public string GetRandomPront()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }

        public string GetRandomQuestion()
        {
            Random random = new Random();
            int index = random.Next(_questions.Count);
            return _questions[index];
        }

        public void DisplayPrompt()
        {
            string prompt = GetRandomPront();
            Console.WriteLine($"--- {prompt} ---");
        }
        public void DisplayQuestion()
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"--- {question} ---");
        }

}


