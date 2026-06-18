public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        GetListFromUser();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"List as many responses you can to the following prompt:\n --- {_prompts[index]} ---");
        Console.Write("You may begin in: ");
        DateTime countdownEndTime = DateTime.Now.AddSeconds(5);
        ShowCountdown(5, countdownEndTime);
        Console.WriteLine("Now list as many things as you can!");
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                responses.Add(response);
                _count++;
            }
        }
        Console.WriteLine($"You listed {_count} items!");
        return responses;
    }


}