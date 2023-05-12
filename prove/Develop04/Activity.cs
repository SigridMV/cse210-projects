public class Activity
{
    // store the information about the activity.
    // stores the name of the activity.
    protected string _activity;
    // stores the description of the activity.
    protected string _description;
    // stores the duration of the activity.
    private int _durationInSeconds;
    // stores the end time of the activity.
    protected DateTime _endTime;

    //Constructor of the Activity class.
    // initializes the variables.
    public Activity (string activity, string description)
    {
        _activity = activity;
        _description = description;
    }

    // method asks the user for the duration of the activity.
    public void AskForDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _durationInSeconds = int.Parse(Console.ReadLine());
    }

    // Method displays the initial message of the activity.
    // It clears the console, displays the activity name and description,
    // asks for the duration, shows a countdown, and sets the end time.
    public void InicialMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activity}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        AskForDuration();
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        PausingShowingSpinner(4);
        DateTime startTime = DateTime.Now;
        _endTime = startTime.AddSeconds(_durationInSeconds);

    }
    // Method displays the final message of the activity.
    // It shows a congratulations message, the duration of the activity,
    // and a countdown before exiting.
    public void LastMessage()
    {
        Console.WriteLine();
        Console.WriteLine("\nWell done!!");
        PausingShowingSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_durationInSeconds} seconds of the {_activity}. ");
        PausingShowingSpinner(5);
        
    }
   
    // Method displays a spinning animation for a specified duration.
    // It takes an integer parameter _duration, which specifies the duration of the animation.
    public void PausingShowingSpinner(int _durationInSeconds)
    {
        // This list contains the symbols used for the animation.
        List <string> animationString = new List<string> ()
        {
            "|" ,"/","-","\\"
        };
        // This sets the start and end times for the animation.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationInSeconds);

        // This is the index of the current symbol.
        int i = 0;

       // This loop displays the spinning animation.
       while (DateTime.Now < endTime)
        {
            string spinning = animationString [i];
            Console.Write(spinning);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i>=animationString.Count)
            {
                i = 0;
            }
        }
    }
    // Method displays a countdown for a specified duration.
    // It takes an integer parameter number, which specifies the duration of the countdown.
    public void PausingShowingCountdownTime(int seconds)
    {
        // This sets the start and end times for the countdown.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

       // This loop displays the countdown.
       while (DateTime.Now < endTime && seconds > 0)
        {

            Console.Write(seconds);
            Thread.Sleep(1000);
            if(seconds.ToString().Length == 1 )
            {
                Console.Write("\b \b");
            }
            else
            {
                Console.Write("\b \b\b \b");
            }
            seconds--;           
        }
    }
}