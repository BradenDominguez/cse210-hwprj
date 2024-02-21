// using System;
// using System.Collections.Generic;
// class RandomGenerator
// {
//     private HashSet<int> intNumbers = new HashSet<int>();
//     private HashSet<float> floatNumbers = new HashSet<float>();
//     private Random random = new Random();
//     public RandomGenerator(){
        
//     }
//     public int NextUniqueNumber(int min, int max)
//     {
//         int number;
//         do
//         {
//             number = random.Next(min, max);
//         } while (intNumbers.Contains(number));
//         intNumbers.Add(number);
//         return number;
//     }
//     public float NextUniqueNumber(float min, float max)
//     {
//         float number;
//         do
//         {
//             number = min + (float)random.NextDouble() * (max - min);
//         } while (floatNumbers.Contains(number));
//         floatNumbers.Add(number);
//         return number;
//     }
// }