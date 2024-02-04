using System;
using System.Threading;

public class ListingActivity : Activity
{
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }
    public void Run()
    {
        GetRandomPrompt();
        ShowSpinner(3);
        GetListFromUser();
    }
    void GetRandomPrompt()
    {
        Console.WriteLine(ListPrompts.GetQuestion());
    }
    List<string> GetListFromUser()
    {
        string assert;
        Console.WriteLine("\nWrite as many words as you can that relate, or exit to stop:");
        List<string> Responses = new List<string>();
        do{
        assert = (Console.ReadLine()).ToString();
        Responses.Add(assert);
        }while (assert != "exit");
        return Responses;
    }
}
