class ListPrompts
{
    
    private static List<string> Questions = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?"};
    private static Random randomGenerator = new Random();
    public static string GetQuestion()
    {
        int number = randomGenerator.Next(0, Questions.Count);
        string newQuestion = Questions[number];
        return newQuestion;
    }
}