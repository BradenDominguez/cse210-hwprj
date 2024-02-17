using System;
using System.Collections.Generic;
class RandomGenerator
{
    private HashSet<int> generatedNumbers = new HashSet<int>();
    private Random random = new Random();
    public RandomGenerator(){
        
    }
    public int NextUniqueNumber(int min, int max)
    {
        int number;
        do
        {
            number = random.Next(min, max); // Generate a random number between 1 and 10
        } while (generatedNumbers.Contains(number)); // Check if the number has already been generated

        generatedNumbers.Add(number); // Add the number to the set of generated numbers
        return number;
    }
}