public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {}

    public void Run()
    {
        DisplayStartingMessage();
        int duration = _duration;

        DateTime futureTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now <= futureTime)
        {
            Console.WriteLine("\n");
            Console.Write( "Breathe in..." );
            ShowCountdown(4, futureTime);
            Console.WriteLine("");
            Console.Write("Now Breathe out...");
            ShowCountdown(4, futureTime); 
        }
        
        DisplayEndingMessage();

    }
}