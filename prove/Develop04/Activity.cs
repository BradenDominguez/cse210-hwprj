public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to this activity, {_name}. {_description}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Activity completed. Returning back to the menu.");
    }
    public void ShowSpinner(int seconds)
    {
        List<string> Animation = new List<string>();
        Animation.Add("|");
        Animation.Add("\b/");
        Animation.Add("\b-");
        Animation.Add("\b\\");
        foreach (string s in Animation)
        {
            Console.Write(s);
            Thread.Sleep(seconds*1000);
            Console.Write("\b \b");
        }
    }
    void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
        }
    }
}