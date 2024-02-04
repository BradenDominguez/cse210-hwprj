using System;
using System.Threading;

public class ListingActivity : Activity
{
    private string _count;
    private List<string> _prompts;
    ListingActivity(string name, string description, int duration, string count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }
    void Run()
    {
        Console.Write("List good things that relate to the following prompt:");
    }
    void GetRandomPrompt()
    {
        Console.WriteLine(Prompt.GetPrompt());
    }
    List<string> GetListFromUser()
    {
        List<string> words = new List<string>();
        return words;
    }
}
