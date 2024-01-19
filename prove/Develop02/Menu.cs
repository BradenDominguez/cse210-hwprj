using System;
using System.IO;
class Menu
{
    public static void Initialize()
    {
    string menu;
    string content = "";
    do
    {
        Console.WriteLine("");
        Console.WriteLine("Please enter a number.");
        Console.WriteLine("1.Load Journal");
        Console.WriteLine("2.Display Journal");
        Console.WriteLine("3.Write");
        Console.WriteLine("4.Save Journal");
        Console.WriteLine("5.Exit");
        menu = Console.ReadLine();
        if (menu == "1"){
            string path = Console.ReadLine();
            content = FileReader.ReadFile(path);
        }else if (menu == "2"){
            Display.DisplayContent(content);
        }else if (menu == "3"){
            content = Inscribe.InscribeContent(content);
        }else if (menu == "4"){
            string path = Console.ReadLine();
            FileWriter.WriteFile(path, content);
        }
    }while (menu!= "5");
    Console.WriteLine("Good day.");
    }
}