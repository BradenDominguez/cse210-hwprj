public class MarkProgress
{
    public static Dictionary<string, List<string>> Mark(Dictionary<string, List<string>> goals)
    {
        Console.WriteLine($"Input key:");
        string key = Console.ReadLine();
        List<string> values = goals[key];
        string GoalType = values[0];
        string Description = values[1];
        string Completion = values[2];
        string Score = values[3];
        values = ScoreMenu(key, GoalType, Description, Completion, Score);
        goals[key] = values;
        return goals;
    }
    public static List<string> ScoreMenu(string Name, string GoalType, string Description, string Completion, string Score)
    {
        List<string> values;
        if (GoalType == "Eternal"){
            EternalGoal eternalGoal = new EternalGoal(Name, GoalType, Description, Completion, Score);
            Completion = eternalGoal.Completion();
            Score = eternalGoal.Scoring(Score);
        }else if(GoalType == "Checklist"){
            ChecklistGoal checklistGoal = new ChecklistGoal(Name, GoalType, Description, Completion, Score);
            List<string> checks = checklistGoal.Step(Completion, Score);
            Completion = checks[0];
            Score = checks[1];
        }else if(GoalType == "Simple"){
            SimpleGoal simpleGoal = new SimpleGoal(Name, GoalType, Description, Completion, Score);
            Completion = simpleGoal.Completion();
            Score = simpleGoal.Scoring(Score);
        }
        Console.WriteLine($"{Name} is now marked at {Completion} for {Score} points.");
        values = new List<string> {GoalType, Description, Completion, Score};
        return values;
    }
}