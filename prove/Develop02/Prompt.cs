class Prompt
{
    
    private static List<string> Prompts = new List<string> { "What was the strangest thing you saw today?", "What was your favorite part of the day?", "What is something you've thought a lot about today?", "What is something you've been wanting to tell someone, but haven't worked out the words for?", "If you could do anything today, what would it be?" };
    private static Random randomGenerator = new Random();
    public static string GetPrompt()
    {
        int number = randomGenerator.Next(0, Prompts.Count);
        string newPrompt = Prompts[number];
        return newPrompt;
    }
}