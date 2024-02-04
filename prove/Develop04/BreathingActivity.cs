using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }
    public void Run()
    {
        for (int i = _duration; i > 0; i--)
        {
            Console.WriteLine("Breathe In  ");
            Thread.Sleep(500);
            Console.WriteLine("Breathe Out ");
            Thread.Sleep(500);
            Console.WriteLine("           ");
        }
        Console.WriteLine("You really breathed good.");
    }

}
