public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Welcome to this activity.");
    }
    void DisplayEndingMessage()
    {
        Console.WriteLine("Back to the menu.");
    }
    void ShowSpinner(int seconds)
    {
        List<string> Animation = new List<string>();
        Animation.Add("|");
        Animation.Add("\b/");
        Animation.Add("\b-");
        Animation.Add("\b\\");
        foreach (string s in Animation)
        {
            Console.Write(s);
            Thread.Sleep(1000);
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