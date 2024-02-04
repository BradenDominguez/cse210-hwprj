public class ReflectingActivity : Activity
{
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }
    public void Run()
    {
        GetRandomPrompt();
        ShowSpinner(3);
        GetRandomQuestion();
        GetResponse();
    }
    void GetRandomPrompt()
    {
        string prompt = Prompt.GetPrompt();
        Console.WriteLine($"Think of a time involving {prompt.ToLower()}");
    }
    void GetRandomQuestion()
    {
        string question = Question.GetQuestion();
        Console.WriteLine($"\n{question}");
    }
    List<string> GetResponse()
    {
        string assert;
        Console.WriteLine("Write your responses, or exit to stop:");
        List<string> Responses = new List<string>();
        do{
        assert = (Console.ReadLine()).ToString();
        Responses.Add(assert);
        }while (assert != "exit");
        return Responses;
    }
}
