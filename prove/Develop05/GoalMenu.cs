public class GoalMenu
{
    private Dictionary<string, List<string>> _goals;
    public GoalMenu()
    {
        _goals = new Dictionary<string, List<string>>();
        string content = FileReader.ReadFile(@"D:\Projects\Programming\C#\CSE210\cse210-hwprj\prove\Develop05\Goals.csv");    
        _goals = CSV.CSVToDict(_goals, content);
    }
    public void SetGoals(Dictionary<string, List<string>> goals)
    {
        // Console.WriteLine("Load from where?");
        // this.goals = CSV.CSVToDict(goals, Console.ReadLine());
        _goals = goals;
    }
    public void LoadGoals()
    {
        Console.WriteLine("Load from where?");
        _goals = new Dictionary<string, List<string>>();
        _goals = CSV.CSVToDict(_goals, Console.ReadLine());
    }
    public Dictionary<string, List<string>> GetGoals()
    {
        return _goals;
    }
    public void Display()
    {
        Console.WriteLine("Your Goals:");
        foreach (string key in _goals.Keys)
        {
            Console.WriteLine(key);
            List<string> values = _goals[key];
            foreach (string value in values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("");
        }
    }
    public void Score()
    {
        int score = 0;
        foreach (string key in _goals.Keys)
        {
            List<string> values = _goals[key];
            score += int.Parse(values[3]);
        }
        Console.WriteLine($"The total score is: {score}");
    }
    public void Mark()
    {
        Dictionary<string, List<string>> goals = GetGoals();
        MarkProgress.Mark(goals);
        SetGoals(goals);
    }
    public void Save()
    {
        // Console.WriteLine("Load from where?");
        // string path = Console.ReadLine();
        string path = @"D:\Projects\Programming\C#\CSE210\cse210-hwprj\prove\Develop05\Goals.csv";
        FileWriter.WriteFile(path, _goals);
    }
    public void New()
    {
        NewGoal newGoal = new NewGoal();
        _goals = newGoal.Create(_goals);
    }
}