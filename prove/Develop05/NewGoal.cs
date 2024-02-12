class NewGoal
{
    private List<string> _values;
    private Dictionary<string, List<string>> _goals;
    public NewGoal(){
        _values = new List<string> {};
    }
    public Dictionary<string, List<string>> Create(Dictionary<string, List<string>> goals)
    {
        _goals = goals;
        Console.WriteLine("What will the name be?");
        string name = Console.ReadLine();
        Console.WriteLine("What type of goal?");
        List<List<string>> types = new List<List<string>>();
        types.Add(new List<string> {"Eternal", "NewGoal", "Eternal", "true"});
        types.Add(new List<string> {"Checklist", "NewGoal", "Checklist", "true"});
        types.Add(new List<string> {"Simple", "NewGoal", "Simple", "true"});
        types.Add(new List<string> {"Quit", "BasicMenu", "End", "true"});
        string type = BasicMenu.Initialize(types);
        if (type == "Eternal"){
            Eternal();
        }else if (type == "Checklist"){
            Checklist();
        }else if (type == "Simple"){
            Simple();
        }
        if (!_goals.ContainsKey(name))
            {
                _goals[name] = new List<string>();
            }
            foreach(string value in _values)
            {
                _goals[name].Add($"{value}");
            }
        return _goals;
    }
    public void Eternal()
    {
        List<string> values = new List<string>();
        values.Add("Eternal");
        Console.WriteLine("What is the description?");
        values.Add(Console.ReadLine());
        values.Add("Not started");
        values.Add("0");
        _values = values;
    }
    public void Checklist()
    {
        List<string> values = new List<string>();
        values.Add("Checklist");
        Console.WriteLine("What is the description?");
        values.Add(Console.ReadLine());
        Console.WriteLine("How many times will you do this?");
        values.Add($"0/{Console.ReadLine()}");
        values.Add("0");
        _values = values;
    }
    public void Simple()
    {
        List<string> values = new List<string>();
        values.Add("Simple");
        Console.WriteLine("What is the description?");
        values.Add(Console.ReadLine());
        values.Add("Not started");
        values.Add("0");
        _values = values;
    }
}