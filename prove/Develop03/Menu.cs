using System;
using System.IO;
// I brought back the menu for more options, like writing your own verses or loading one from a file.
class Menu
{
    public static void Initialize()
    {
    string menu;
    string content = "";
    string path;
    Display displayObject = new Display();
    do
    {
        Console.WriteLine("");
        // Console.Clear();
        Console.WriteLine("Please enter a number.");
        Console.WriteLine("1.Load Scripture File");
        Console.WriteLine("2.Write Your Scripture: ");
        Console.WriteLine("3.Display Scripture");
        Console.WriteLine("4.Exit");
        menu = Console.ReadLine();
        if (menu == "1"){
            Console.WriteLine("Input path: ");
            path = Console.ReadLine();
            content = FileReader.ReadFile(path);
        }else if (menu == "2"){
            content = Inscribe.InscribeContent(content);
        }else if (menu == "3"){
            displayObject.DisplayContent(content);
        }
    }while (menu!= "4");
    Console.WriteLine("Good day.");
    }
}