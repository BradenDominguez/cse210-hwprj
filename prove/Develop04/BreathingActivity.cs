using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }
    public void Run()
    {
        Console.WriteLine("This activity will help you breathe. How many seconds do you want to breathe?");
        int seconds = int.Parse(Console.ReadLine());
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("Breathe In  ");
            Thread.Sleep(500);
            
            Console.Write("Breathe Out ");
            Thread.Sleep(500);
            Console.Write("           ");
        }
        Console.WriteLine("You really breathed good.");
    }

}
