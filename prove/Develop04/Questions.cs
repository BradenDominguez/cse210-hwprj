class Question
{
    
    private static List<string> Questions = new List<string> { "How did it make you feel?", "What was the last interaction you had?", "When is the last time you saw it?"};
    private static Random randomGenerator = new Random();
    public static string GetQuestion()
    {
        int number = randomGenerator.Next(0, Questions.Count);
        string newQuestion = Questions[number];
        return newQuestion;
    }
}