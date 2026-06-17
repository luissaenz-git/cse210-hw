public class Activity
{
    protected string _name;
    protected string _description;

    private int _duration;

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

    private List<string> _countdownStrings = new List<string>()
    {
        "3",
        "2",
        "1"
    };

    

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {}

    public void DisplayEndingMessage()
    {}

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

    public void ShowCountdown(int seconds)
    {}

}