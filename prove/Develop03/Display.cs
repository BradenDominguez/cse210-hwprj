using System;
using System.IO;
class Display
{
    private string _menu;
    public void DisplayContent(string content)
    {
        do
        {
            Console.WriteLine("Selected Scripture:\n");
            Console.WriteLine(content);
            content = Replace.UnderscoreWord(content);
            Console.WriteLine("\nPress enter to continue, or type quit to leave: ");
            _menu = Console.ReadLine();
            ClearConsole();
        }while (_menu!= "quit");
    }
    private static void ClearConsole()
    {
        // It kept giving me errors, and this is what the internet reccomended:
        try
        {
            Console.Clear();
        }
        catch (System.IO.IOException)
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n");
        }
    }
}