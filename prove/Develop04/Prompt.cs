class Prompt
{
    
    private static List<string> Prompts = new List<string> { "The temple.", "Your house.", "Your family.", "Your job." };
    private static Random randomGenerator = new Random();
    public static string GetPrompt()
    {
        int number = randomGenerator.Next(0, Prompts.Count);
        string newPrompt = Prompts[number];
        return newPrompt;
    }
}