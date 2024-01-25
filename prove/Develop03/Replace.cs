using System;
using System.Text;
using System.Text.RegularExpressions;
class Replace
{
    private static Random randomGenerator = new Random();

    public static string UnderscoreWord(string content)
    {
        string[] words = content.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            int number1 = randomGenerator.Next(0, words.Length);
            int number2 = randomGenerator.Next(0, words.Length);
            if (number1 == i || number2 == i)
            {
                words[i] = GenerateUnderscores(words[i].Length);
            }
        }

        return string.Join(" ", words);
    }
    private static string GenerateUnderscores(int length)
    {
        StringBuilder underscores = new StringBuilder();
        for (int i = 0; i < length; i++)
        {
            underscores.Append('_');
        }
        return underscores.ToString();
    }
}