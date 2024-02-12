abstract class Goal
{
    private string _name;
    private string _goalType;
    private string _description;
    private string _completion;
    private string _score;
    public Goal(string name, string goalType, string description, string completion, string score)
    {
        _name = name;
        _goalType = goalType;
        _description = description;
        _completion = completion;
        _score = score;
    }
    public abstract string Completion();
    public abstract string Scoring(string score);
}