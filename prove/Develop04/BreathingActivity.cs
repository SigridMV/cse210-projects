public class BreathingActivity : Activity
{
    public BreathingActivity(string activity, string description) : base (activity, description)
    {
        // Constructor
    }

    public void Inhale()
    {
        Console.WriteLine();
        Console.Write("Breath in..."); // Display the message for inhaling
        PausingShowingCountdownTime(3); // Pause for 3 seconds before the next step
    }

    public void Exhale()
    {
        Console.Write("\nNow breath out...");// Display the message for exhaling
        PausingShowingCountdownTime(6); // Pause for 6 seconds before the next step
        Console.WriteLine();
    }

    public void DoBreathingExercise()
    {
        // A method that performs a breathing exercise until the end time is reached
         while(DateTime.Now < _endTime)
        {
            Inhale(); // Inhale for 3 seconds
            if (DateTime.Now <_endTime)
            {
                Exhale(); // Exhale for 6 seconds if there's still time left
            }
        }
    }    
}

