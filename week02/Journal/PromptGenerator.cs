public class PromptGenerator
{

    //member variables or attributes

    public List<string> _prompts;
    private Random random;
    //the methods

    public string GetRandonPrompt()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        random = new Random();
        
        // Generates a random index within the range of the list
        int index = random.Next(_prompts.Count);

        // Returns the string at the random index position
        return _prompts[index];



        
    }


}