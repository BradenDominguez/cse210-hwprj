using System;
class Program
{
    static void Main(string[] args)
    {
        PrivateNumberClass Fraction = new PrivateNumberClass();

        Fraction.SetFraction();
        Console.WriteLine("Fraction with no criteria: " + Fraction.GetFractionString());

        double equation = Fraction.GetDecimalValue();
        Console.WriteLine($"Fraction as a decimal: {equation}");

        Fraction.SetFraction(6);
        Console.WriteLine("Fraction with one criteria: " + Fraction.GetFractionString());

        equation = Fraction.GetDecimalValue();
        Console.WriteLine($"Fraction as a decimal: {equation}");

        Fraction.SetFraction(6,7);
        Console.WriteLine("Fraction with two criteria: " + Fraction.GetFractionString());

        equation = Fraction.GetDecimalValue();
        Console.WriteLine($"Fraction as a decimal: {equation}");
    }
}