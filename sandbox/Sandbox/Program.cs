// using System.Reflection;
// class NewGoal
// {
//     private List<string> _values;
//     private Dictionary<string, List<string>> _goals;
//     public NewGoal(Dictionary<string, List<string>> goals){
//         _goals = goals;
//         _values = new List<string> {};
//     }
//     public Dictionary<string, List<string>> Create()
//     {
//         Console.WriteLine("What will the name be?");
//         string name = Console.ReadLine();
//         Console.WriteLine("What type of goal?");
//         List<List<string>> types = new List<List<string>>();
//         types.Add(new List<string> {"Eternal", "NewGoal", "Eternal", "true"});
//         types.Add(new List<string> {"Checklist", "NewGoal", "Checklist", "true"});
//         types.Add(new List<string> {"Simple", "NewGoal", "Simple", "true"});
//         types.Add(new List<string> {"Quit", "BasicMenu", "End", "true"});
//         BasicMenu.Initialize(types);
//         if (!_goals.ContainsKey(name))
//             {
//                 _goals[name] = new List<string>();
//             }
//             foreach (string value in _values)
//             {
//                 _goals[name].Add($"{value}");
//             }
//         return _goals;
//     }
//     public void Eternal()
//     {
//         List<string> values = new List<string>();
//         values.Add("Eternal");
//         Console.WriteLine("What is the description?");
//         values.Add(Console.ReadLine());
//         values.Add("Not started");
//         values.Add("0");
//         _values = values;
//     }
//     public void Checklist()
//     {
//         List<string> values = new List<string>();
//         values.Add("Checklist");
//         Console.WriteLine("What is the description?");
//         values.Add(Console.ReadLine());
//         Console.WriteLine("How many times will you do this?");
//         values.Add($"0/{Console.ReadLine()}");
//         values.Add("0");
//         _values = values;
//     }
//     public void Simple()
//     {
//         List<string> values = new List<string>();
//         values.Add("Simple");
//         Console.WriteLine("What is the description?");
//         values.Add(Console.ReadLine());
//         values.Add("Not started");
//         values.Add("0");
//         _values = values;
//     }
// }
// public class GoalMenu
// {
//     private Dictionary<string, List<string>> _goals;
//     public GoalMenu()
//     {
//         _goals = new Dictionary<string, List<string>>();
//         string content = FileReader.ReadFile(@"D:\Projects\Programming\C#\CSE210\cse210-hwprj\prove\Develop05\Goals.csv");    
//         _goals = CSV.CSVToDict(_goals, content);
//     }
//     public void SetGoals(Dictionary<string, List<string>> goals)
//     {
//         // Console.WriteLine("Load from where?");
//         // this.goals = CSV.CSVToDict(goals, Console.ReadLine());
//         _goals = goals;
//     }
//     public void LoadGoals()
//     {
//         Console.WriteLine("Load from where?");
//         _goals = new Dictionary<string, List<string>>();
//         _goals = CSV.CSVToDict(_goals, Console.ReadLine());
//     }
//     public Dictionary<string, List<string>> GetGoals()
//     {
//         return _goals;
//     }
//     public void Display()
//     {
//         Console.WriteLine("Your Goals:");
//         foreach (string key in _goals.Keys)
//         {
//             Console.WriteLine(key);
//             List<string> values = _goals[key];
//             foreach (string value in values)
//             {
//                 Console.WriteLine(value);
//             }
//             Console.WriteLine("");
//         }
//     }
//     public void Score()
//     {
//         int score = 0;
//         foreach (string key in _goals.Keys)
//         {
//             List<string> values = _goals[key];
//             score += int.Parse(values[3]);
//         }
//         Console.WriteLine($"The total score is: {score}");
//     }
//     public void Mark()
//     {
//         Dictionary<string, List<string>> goals = GetGoals();
//         MarkProgress.Mark(goals);
//         SetGoals(goals);
//     }
//     public void Save()
//     {
//         // Console.WriteLine("Load from where?");
//         // string path = Console.ReadLine();
//         string path = @"D:\Projects\Programming\C#\CSE210\cse210-hwprj\prove\Develop05\Goals.csv";
//         FileWriter.WriteFile(path, _goals);
//     }
//     public void New()
//     {
//         NewGoal newGoal = new NewGoal(_goals);
//         _goals = newGoal.Create();
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         GoalMenu goalMenu = new GoalMenu();
//         List<List<string>> mainMenu = new List<List<string>>();
//         mainMenu.Add(new List<string> {"Load Goals", "GoalMenu", "LoadGoals"});
//         mainMenu.Add(new List<string> {"Display Goals", "GoalMenu", "Display"});
//         mainMenu.Add(new List<string> {"See Score", "GoalMenu", "Score"});
//         mainMenu.Add(new List<string> {"Mark as Complete", "GoalMenu", "Mark"});
//         mainMenu.Add(new List<string> {"New Goal", "GoalMenu", "New"});
//         mainMenu.Add(new List<string> {"Save Goals", "GoalMenu", "Save"});
//         mainMenu.Add(new List<string> {"Quit", "BasicMenu", "End"});
//         Menu.Initialize(mainMenu, goalMenu);
//         Console.WriteLine("Good day.");
//     }
// }
// class BasicMenu
// {
//     public static void Initialize(List<List<string>> list)
//     {
//         Dictionary<string, List<string>> options = ToDict(list);
//         string menu = "0";
//         int menus = options.Count();
//         do
//             {
//             Console.WriteLine("Please enter a number.");
//             foreach(string key in options.Keys)
//             {
//                 List<string> values = options[key];
//                 Console.WriteLine($"{key}. {values[0]}");
//             }
//             menu = Console.ReadLine();
//             if (options.ContainsKey(menu))
//             {
//                 string className = options[menu][1];
//                 string methodName = options[menu][2];
//                 string runOnce = options[menu][3];
//                 Type classType = Type.GetType(className);
//                 MethodInfo methodInfo = classType.GetMethod(methodName);
//                 if (methodInfo != null)
//                 {
//                     object instance = Activator.CreateInstance(classType);
//                     methodInfo.Invoke(instance, null);
//                     if (runOnce == "true"){
//                         menu = $"{menus}";
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Method '{methodName}' not found in class '{className}'.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Invalid option. Please try again.");
//             }
//         }while (int.Parse(menu) != menus);       
//     }
//     public static Dictionary<string, List<string>> ToDict(List<List<string>> options)
//     {
//         Dictionary<string, List<string>> menu = new Dictionary<string, List<string>>();
//         int i = 0;
//         foreach(List<string> option in options)
//         {
//             i++;
//             string key = i.ToString();
//             menu[key] = new List<string>();
//             menu[key].AddRange(option);
//         }
//         return menu;
//     }
//     public static void End()
//     {
//         Console.WriteLine($"Returning to previous menu.");
//     }
// }
// using System.Reflection;
// class Menu
// {
//     public static void Initialize(List<List<string>> list, GoalMenu menuObject)
//     {
//         Dictionary<string, List<string>> options = ToDict(list);
//         string menu = "0";
//         int menus = options.Count();
//         do
//             {
//             Console.WriteLine("Please enter a number.");
//             foreach(string key in options.Keys)
//             {
//                 List<string> values = options[key];
//                 Console.WriteLine($"{key}. {values[0]}");
//             }
//             menu = Console.ReadLine();
//             if (options.ContainsKey(menu))
//             {
//                 string className = options[menu][1];
//                 string methodName = options[menu][2];
//                 Type classType = Type.GetType(className);
//                 MethodInfo methodInfo = classType.GetMethod(methodName);
//                 if (methodInfo != null)
//                 {
//                     methodInfo.Invoke(menuObject, null);
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Method '{methodName}' not found in class '{className}'.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Invalid option. Please try again.");
//             }
//         }while (int.Parse(menu) != menus);       
//     }
//     public static Dictionary<string, List<string>> ToDict(List<List<string>> options)
//     {
//         Dictionary<string, List<string>> menu = new Dictionary<string, List<string>>();
//         int i = 0;
//         foreach(List<string> option in options)
//         {
//             i++;
//             string key = i.ToString();
//             menu[key] = new List<string>();
//             menu[key].AddRange(option);
//         }
//         return menu;
//     }
//     public static void End()
//     {
//     }
// }
// public class MarkProgress
// {
//     public static Dictionary<string, List<string>> Mark(Dictionary<string, List<string>> goals)
//     {
//         Console.WriteLine($"Input key:");
//         string key = Console.ReadLine();
//         List<string> values = goals[key];
//         string GoalType = values[0];
//         string Description = values[1];
//         string Completion = values[2];
//         string Score = values[3];
//         values = ScoreMenu(key, GoalType, Description, Completion, Score);
//         goals[key] = values;
//         return goals;
//     }
//     public static List<string> ScoreMenu(string Name, string GoalType, string Description, string Completion, string Score)
//     {
//         List<string> values;
//         if (GoalType == "Eternal"){
//             EternalGoal eternalGoal = new EternalGoal(Name, GoalType, Description, Completion, Score);
//             Completion = eternalGoal.Completion();
//             Score = eternalGoal.Scoring(Score);
//         }else if(GoalType == "Checklist"){
//             ChecklistGoal checklistGoal = new ChecklistGoal(Name, GoalType, Description, Completion, Score);
//             List<string> checks = checklistGoal.Step(Completion, Score);
//             Completion = checks[0];
//             Score = checks[1];
//         }else if(GoalType == "Simple"){
//             SimpleGoal simpleGoal = new SimpleGoal(Name, GoalType, Description, Completion, Score);
//             Completion = simpleGoal.Completion();
//             Score = simpleGoal.Scoring(Score);
//         }
//         Console.WriteLine($"{Name} is now marked at {Completion} for {Score} points.");
//         values = new List<string> {GoalType, Description, Completion, Score};
//         return values;
//     }
// }