class Program
{
    static void Main(string[] args)
    {
        List<List<string>> mainMenu = new List<List<string>>();
        mainMenu.Add(new List<string> {"Classic", "Program", "LoadClassic", "false"});
        mainMenu.Add(new List<string> {"Sleuth", "", "Display", "false"});
        mainMenu.Add(new List<string> {"Trait", "", "Score", "false"});
        mainMenu.Add(new List<string> {"Cursed Object", "", "Mark", "false"});
        mainMenu.Add(new List<string> {"List", "Ghosts", "List", "true"});
        mainMenu.Add(new List<string> {"Records", "", "Save", "false"});
        mainMenu.Add(new List<string> {"Quit", "BasicMenu", "End", "false"});
        BasicMenu.Initialize(mainMenu);
        Console.WriteLine("Good day.");
    }
    public static void LoadClassic(){
        Ghosts ghosts = new Ghosts();
        string ghost =ghosts.GetGhost();
        GameClassic classic = new GameClassic(ghosts.GetGhostDict(), ghost);
        classic.Play();
    }
}
