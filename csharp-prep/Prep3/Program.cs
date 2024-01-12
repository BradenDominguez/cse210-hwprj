using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        string value;
        int guess;
        int attempts = 0;
        do
        {
            attempts++;
            Console.Write("Quess the number: ");
            value = Console.ReadLine();
            guess = int.Parse(value);
            if (guess >= number){
                Console.WriteLine("Too high.");
            }else if (guess <= number){
                Console.WriteLine("Too low.");
            }
        } while (guess != number);
        Console.WriteLine($"It took you {attempts} attempts.");
    }
}