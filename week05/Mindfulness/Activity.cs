namespace Mindfulness;
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting the {_name}.");
        Console.WriteLine(_description);
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Get ready...");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        ShowSpinner(5);

        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int duration)
    {
        List<string> spinnerFrames = new List<string> { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            foreach (string frame in spinnerFrames)
            {
                Console.Write(frame);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }

}