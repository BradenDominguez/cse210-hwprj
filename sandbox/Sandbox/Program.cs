using System;

class Program
{
    static void Main(string[] args)
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
}