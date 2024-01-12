using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string input;
        int sum = 0;
        int avg = 0;
        int max = 0;
        int number;
        do
        {
            Console.Write("Input a number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            if (max <= number){
                max = number;
            }
            sum += number;

            numbers.Add(number);
        } while (input != "0");
        avg = (sum/numbers.Count);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The max is: {max}");
    }
}