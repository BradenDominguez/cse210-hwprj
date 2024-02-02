using System;
class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Test", "Mystery");
        Console.WriteLine(assignment.GetSummary());
        
        MathAssignment mathassignment = new MathAssignment("Lynda", "Trigonomonotry", "A", "1-13");
        Console.WriteLine(mathassignment.GetSummary());
        Console.WriteLine(mathassignment.GetHomeworkList());

        WritingAssignment writingassignment = new WritingAssignment("Jason", "Briterature", "Great Gatsby");
        Console.WriteLine(writingassignment.GetSummary());
        Console.WriteLine(writingassignment.GetWritingInfo());
    }
}