using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"What was your grade?");
        string value = Console.ReadLine();
        int grade = int.Parse(value);
        string letter;
        string status;
        if (grade >= 90)
        {
            letter = "A";
            status = "passing. Congrats!";
        }else if (grade >= 80){
            letter = "B";
            status = "passing. Congrats!";
        }else if (grade >= 70){
            letter = "C";
            status = "passing. Congrats!";
        }else if (grade >= 60){
            letter = "D";
            status = "failing. Please do better.";
        }else{
            letter = "F";
            status = "failing. Please do better.";
        }
        Console.WriteLine($"You recieved a {letter}. You are {status}");
    }
}