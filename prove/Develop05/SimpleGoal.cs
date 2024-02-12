class SimpleGoal : Goal
{
public SimpleGoal(string name, string goalType, string description, string completion, string score) : base(name, goalType, description, completion, score)
    {
    }
    public override string Completion()
    {
        string time = DateTime.Now.ToString();
        return $"Finished on {time}";
    }
    public override string Scoring(string score)
    {
        int newscore = int.Parse(score)+1000;
        return newscore.ToString();
    }
}