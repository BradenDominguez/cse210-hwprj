class Program
{
    static void Main(string[] args)
    {
        List<List<string>> mainMenu = new List<List<string>>();
        mainMenu.Add(new List<string> {"Classic", "Program", "LoadClassic"});
        mainMenu.Add(new List<string> {"Sleuth", "Program", "LoadSleuth"});
        mainMenu.Add(new List<string> {"Trait", "Program", "LoadTrait"});
        mainMenu.Add(new List<string> {"List", "Ghosts", "List"});
        mainMenu.Add(new List<string> {"Quit", "BasicMenu", "End"});
        BasicMenu.Initialize(mainMenu, "false");
    }
    public static void LoadClassic(){
        Ghosts ghosts = new Ghosts();
        string ghost = ghosts.GetGhost();
        GameClassic classic = new GameClassic(ghosts.GetGhostDict(), ghost);
        classic.Play();
    }
    public static void LoadSleuth(){
        Ghosts ghosts = new Ghosts();
        string ghost = ghosts.GetGhost();
        GameSleuth sleuth = new GameSleuth(ghosts.GetGhostDict(), ghost);
        sleuth.Play();
    }
    public static void LoadTrait(){
        Ghosts ghosts = new Ghosts();
        string ghost = ghosts.GetGhost();
        GameTrait trait = new GameTrait(ghosts.GetGhostDict(), ghost);
        trait.Play();
    }
}
