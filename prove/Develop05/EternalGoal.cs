class EternalGoal : Goal
{
public EternalGoal(string name, string goalType, string description, string completion, string score) : base(name, goalType, description, completion, score)
    {
    }
    public override string Completion()
    {
        string time = DateTime.Now.ToString();
        return $"Your last mark is {time}";
    }
    public override string Scoring(string score)
    {
        int newscore = int.Parse(score)+100;
        return newscore.ToString();
    }
}