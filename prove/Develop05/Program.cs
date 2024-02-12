class Program
{
    static void Main(string[] args)
    {
        GoalMenu goalMenu = new GoalMenu();
        // I created a super complicated and adjustable menu system that calls methods from strings, as shown below.
        // Unfortunately it was way harder than I thought it would be, and I spent all week doing that instead of the program.
        List<List<string>> mainMenu = new List<List<string>>();
        mainMenu.Add(new List<string> {"Load Goals", "GoalMenu", "LoadGoals"});
        mainMenu.Add(new List<string> {"Display Goals", "GoalMenu", "Display"});
        mainMenu.Add(new List<string> {"See Score", "GoalMenu", "Score"});
        mainMenu.Add(new List<string> {"Mark as Complete", "GoalMenu", "Mark"});
        mainMenu.Add(new List<string> {"New Goal", "GoalMenu", "New"});
        mainMenu.Add(new List<string> {"Save Goals", "GoalMenu", "Save"});
        mainMenu.Add(new List<string> {"Quit", "BasicMenu", "End"});
        Menu.Initialize(mainMenu, goalMenu);
        Console.WriteLine("Good day.");
    }
}
