public class Activity
{
    protected string _name;
    protected string _description;

    protected int _duration;

    private List<string> _animationStrings = new List<string>()
    {
        "|",
        "/",
        "-",
        "\\",
        "|",
        "/",
        "-",
        "\\"
    };


    

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }   

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Well done!!\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
      DateTime startTime = DateTime.Now;
      DateTime futureTime = startTime.AddSeconds(seconds);

      int i = 0;
      while (DateTime.Now < futureTime)
      {
        string s = _animationStrings[i];
        Console.Write(s);
        Thread.Sleep(100);
        Console.Write("\b \b");
        i++;
        if (i >= _animationStrings.Count)
        {
          i = 0;
        }
      }   
    }

// This method is used to show a countdown timer for the specified number of seconds. 
// /It will display the remaining seconds and update the display every second 
// until the countdown reaches zero or the end time is reached.
// What is the end time?
// The end time is a DateTime object that represents the time at which the countdown should stop.
    public void ShowCountdown(int seconds, DateTime endTime)
    {

// For each second named i. While i is greater than 0 
// and the current time is less than the end time, do the following:
// Remaining calculates the  seconds remaining based on the difference between the end time and the current time.
// Math.Ceiling is used to round up the remaining seconds to the nearest whole number.
// It was implemented to avoid an infinite loop in case the remaining time is less than a second.
        int remaining = (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds);
// displaySeconds uses Math.Min. Math.Min returns the smaller of tow numbers
// With this we can know if it is possible 
// to display the full countdown for the specified number of seconds 
// or if we need to adjust it based on the remaining time. 
        int displaySeconds = Math.Min(seconds, remaining);
        for (int i = displaySeconds; i > 0 && DateTime.Now < endTime; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
    }
    }

}