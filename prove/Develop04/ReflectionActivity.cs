public class ReflectingActivity : Activity

{
    // List of random prompts to be used during reflection
    protected List<string> _prompts = new List<string>
    {
     " ---Think of a time when you stood up for someone else. ---",
     " ---Think of a time when you did something really difficult. ---",
     " ---Think of a time when you helped someone in need. ---",
     " ---Think of a time when you did something truly selfless. ---"
    };

    // List of random questions to be used during reflection
    protected List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you? ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were not as successful? ",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? "
    };

    public ReflectingActivity(string activity, string description) : base(activity, description)
    {

    }

    // Method to display a random prompt
    public string DisplayRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($"{prompt}");
        return prompt;
    }
    // Method to display a random question
    public string DisplayRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string question = _questions[index];
        _questions.RemoveAt(index);
        Console.WriteLine($">{question}");
        return question;
    }

    // Method to complete the reflection activity
    public void ReflectionComplete()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they realated to this experience.");
        Console.Write("\nYou may begin in: ");
        PausingShowingCountdownTime(5); // countdown before starting the reflection questions
        Console.WriteLine();
        while (DateTime.Now < _endTime)
        {

            
            if (DateTime.Now < _endTime)
            {
                // Display additional questions and wait for user input
                
                DisplayRandomQuestion();
                PausingShowingSpinner(5);
            }
        }
        LastMessage();
    }
}