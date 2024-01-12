using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        int y = 4;
        Console.WriteLine($"{x}");

        Console.WriteLine("Please type.");  
        string input = Console.ReadLine();

        if (x > y)
        {
        Console.WriteLine("greater");
        }

        string response = "yes";

        while (response == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }
        
        string response2;

        do
        {
            Console.Write("Do you want to continue? ");
            response2 = Console.ReadLine();
        } while (response2 == "yes");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
        
        List<int> numbers = new List<int>();
        List<string> words = new List<string>();
        words.Add("lol");
        foreach (string item in words)
        {
            Console.WriteLine(item);
        }
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);



    }
}