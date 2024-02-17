class Program
{
    static void Main(string[] args)
    {
        List<List<string>> mainMenu = new List<List<string>>();
        mainMenu.Add(new List<string> {"Classic", "Program", "LoadClassic"});
        mainMenu.Add(new List<string> {"Sleuth", "", "Display"});
        mainMenu.Add(new List<string> {"Trait", "", "Score"});
        mainMenu.Add(new List<string> {"Cursed Object", "", "Mark"});
        mainMenu.Add(new List<string> {"List", "Ghosts", "List"});
        mainMenu.Add(new List<string> {"Records", "", "Save"});
        mainMenu.Add(new List<string> {"Quit", "BasicMenu", "End"});
        BasicMenu.Initialize(mainMenu, "false");
    }
    public static void LoadClassic(){
        Ghosts ghosts = new Ghosts();
        string ghost = ghosts.GetGhost();
        Console.WriteLine($"The ghost is {ghost}");
        GameClassic classic = new GameClassic(ghosts.GetGhostDict(), ghost);


        List<List<string>> settingsMenu = new List<List<string>>();
        settingsMenu.Add(new List<string> {"Evidence", "GameClassic", "EvidenceSetting"});
        settingsMenu.Add(new List<string> {"Hunt", "GameClassic", "HuntSetting"});
        settingsMenu.Add(new List<string> {"Speed", "GameClassic", "SpeedSetting"});
        settingsMenu.Add(new List<string> {"Trait", "GameClassic", "TraitSetting"});
        settingsMenu.Add(new List<string> {"Start", "BasicMenu", "End"});
        // BasicMenu.Initialize(settingsMenu, "false");
        // classic.Settings();
        classic.Play();
    }
}
