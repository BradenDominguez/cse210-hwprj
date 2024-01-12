using System;

class Program
{
    static void Main(string[] args)
    {
        Hello();
        NumberPrint(Name(), Square(Number()));
    }
    static void Hello()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string Name()
    {
        Console.WriteLine("Enter your name:");
        return Console.ReadLine();
    }
    static int Number()
    {
        Console.WriteLine("Enter your favorite number:");
        return int.Parse(Console.ReadLine());
    }
    static int Square(int number)
    {
        int number2 = number * number;
        return number2;
    }
    static void NumberPrint(string name, int number)
    {
        Console.WriteLine($"{name}, your number squared is {number}.");
    }
}