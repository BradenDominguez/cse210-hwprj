using System;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }
    void Run()
    {
        
    }
    string GetRandomPrompt()
    {
        string prompt = Prompt.GetPrompt();
        return prompt;
    }
     string GetRandomQuestion()
    {
        string question = Question.GetQuestion();
        return question;
    }
    void DisplayPrompt()
    {
        // Console.WriteLine(prompt);
    }
    void DisplayQuestion()
    {
        // Console.WriteLine(question);
    }
}
