using System;
using System.IO;
class Inscribe
{
    public static string InscribeContent(string content)
    {
        string prompt = Prompt.GetPrompt();
        Console.WriteLine(prompt);
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        string writ = Console.ReadLine();
        string newContent = $"\n{dateText}\n{prompt}\n{writ}";
        Console.WriteLine("Your entry has been recorded.");
        return newContent;
    }
}