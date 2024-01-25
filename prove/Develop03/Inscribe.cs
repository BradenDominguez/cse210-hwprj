using System;
using System.IO;
class Inscribe
{
    public static string InscribeContent(string content)
    {
        string newContent = Console.ReadLine();
        Console.WriteLine("Your entry has been recorded.");
        return newContent;
    }
}