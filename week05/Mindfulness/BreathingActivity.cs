public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {}

    public void Run()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like to do this activity? ");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        

       

    }
}