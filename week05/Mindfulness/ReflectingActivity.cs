public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();

    private List<string> _availableQuestions = new List<string>();

    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = _duration;
        DisplayPrompt();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        DateTime countdownEndTime = DateTime.Now.AddSeconds(5);
        ShowCountdown(5, countdownEndTime);
        Console.Clear();
        DateTime futureTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < futureTime)
        {
            DisplayQuestions();
            // Calculate the remaining time and determine how long to show the spinner
            // We substract the current time from the future time to get the remaining time in seconds
            int remaining = (int)Math.Ceiling((futureTime - DateTime.Now).TotalSeconds);
            // We use Math.Min to ensure that we don't show the spinner for more than 10 seconds or the remaining time, whichever is smaller
            // If the user set a duaration of less than 10 seconds, we will show the spinner for that duration. 
            // If the user set a duration of more than 10 seconds, we will show the spinner for 10 seconds at a time until the total duration is reached.
            int spinnerDuration = (int)Math.Min(10, remaining);
            if (spinnerDuration > 0)
            {
                ShowSpinner(spinnerDuration);
            }
            if (DateTime.Now < futureTime)
            {
                Console.Write("\n");
            }
        }
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        if (_availableQuestions.Count == 0)
        {
            _availableQuestions = new List<string>(_questions);
        }

        Random random = new Random();
        int index = random.Next(_availableQuestions.Count);
        string question = _availableQuestions[index];
        //RemoveAt is a list method that removes the question that was used from the list of available questions to avoid repetition until all questions have been used.
        _availableQuestions.RemoveAt(index);
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt: \n");
        Console.WriteLine($" --- {GetRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }
}