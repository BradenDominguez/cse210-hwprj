using System.Diagnostics;

class ChecklistGoal : Goal
{
public ChecklistGoal(string name, string goalType, string description, string completion, string score) : base(name, goalType, description, completion, score)
    {
    }
    public List<string> Step(string completion, string score)
    {
        String[] words = completion.Split("/", StringSplitOptions.RemoveEmptyEntries);
        string top = words[0];
        string bottom = words[1];
        int newtop = (int.Parse(top)+1);
        Console.WriteLine(newtop);
        int newbottom = int.Parse(bottom);
        int newscore;
        string done = "";
        if (newtop == newbottom){
            done = Completion();
            newscore = int.Parse(Scoring(score));
        }else{
            done = $"{newtop}/{newbottom}";
            newscore = int.Parse(score)+50;
        }
        return new List<string> {$"{done}", $"{newscore}"};
    }
    public override string Completion()
    {
        string time = DateTime.Now.ToString();
        return $"Finished on {time}";
    }
    public override string Scoring(string score)
    {
        int newscore = int.Parse(score)+500;
        return newscore.ToString();
    }
}