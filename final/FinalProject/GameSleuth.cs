using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Policy;

class GameSleuth : Game
{
    protected string _evidenceSetting;
    protected string _huntSetting;
    protected string _speedSetting;
    protected string _traitSetting;
    public GameSleuth(Dictionary<string, List<List<string>>> ghosts, string ghost) : base(ghosts, ghost)
    {
    _evidenceSetting = "3";
    _huntSetting = "1";
    _speedSetting = "1";
    _traitSetting = "2";
    }
    public void setEvidence(){
        Console.WriteLine("Input a number:");
        Console.WriteLine("3. Three Evidence");
        Console.WriteLine("2. Two Evidence");
        Console.WriteLine("1. One Evidence");
        Console.WriteLine("0. Zero Evidence");
        string valid = "false";
        string setting;
        do{
            setting = Console.ReadLine();
            if (setting == "3" || setting == "2" || setting == "1" || setting == "0"){
                valid = "true";
            }else{
                Console.WriteLine("Invalid response.");
            }
        }while(valid == "false");
        _evidenceSetting = setting;
    }
    public void getEvidence(){
        List<string> Evidences = _ghosts[_ghost][0];
        List<string> Evidence = new List<string>();
        Random random = new Random();
        int i;
        if(_ghost == "mimic"){
            Evidence.Add(Evidences[3]);
        }
        if(_evidenceSetting == "3"){
            Evidence.Add(Evidences[0]);
            Evidence.Add(Evidences[1]);
            Evidence.Add(Evidences[2]);
            _ghosts[_ghost][0] = Evidence;
        }
        else if(_evidenceSetting == "2")
        {
            if (Evidences[3] != "None"){
                Evidence.Add(Evidences[3]);
                do{
                    i = random.Next(0,3);
                }while (Evidence.Contains(Evidences[i]));
                    Evidence.Add(Evidences[i]);
            }else{
                i = random.Next(0,3);
                Evidence.Add(Evidences[i]);
                do{
                    i = random.Next(0,3);
                }while (Evidence.Contains(Evidences[i]));
                Evidence.Add(Evidences[i]);
            }
        }
        else if(_evidenceSetting == "1")
        {
            if (Evidences[3] != "None"){
                Evidence.Add(Evidences[3]);
            }else{
                i = random.Next(0,3);
                Evidence.Add(Evidences[i]);
            }
        }
        _ghosts[_ghost][0] = Evidence;
    }
    public void setHunt(){
        Console.WriteLine("Input a number:");
        Console.WriteLine("1. Enabled");
        Console.WriteLine("2. Disabled");
        string valid = "false";
        string setting;
        do{
            setting = Console.ReadLine();
            if (setting == "1" || setting == "2"){
                valid = "true";
            }else{
                Console.WriteLine("Invalid response.");
            }
        }while(valid == "false");
        _huntSetting = setting;
    }
    public void getHunt(){
        if(_huntSetting == "2")
        {
            _ghosts[_ghost][1][0] = "0";
        }
        
    }
    public void setSpeed(){
        Console.WriteLine("Input a number:");
        Console.WriteLine("1. Enabled");
        Console.WriteLine("2. Disabled");
        string valid = "false";
        string setting;
        do{
            setting = Console.ReadLine();
            if (setting == "1" || setting == "2"){
                valid = "true";
            }else{
                Console.WriteLine("Invalid response.");
            }
        }while(valid == "false");
        _speedSetting = setting;
    }
    public void getSpeed(){
        if(_speedSetting == "2")
        {
            _ghosts[_ghost][2][0] = "0";
        }
    }
    public void setTrait(){
        Console.WriteLine("Input a number:");
        Console.WriteLine("2. All Traits");
        Console.WriteLine("1. Some Traits");
        Console.WriteLine("0. No Traits");
        string valid = "false";
        string setting;
        do{
            setting = Console.ReadLine();
            if (setting == "2" || setting == "1" || setting == "0"){
                valid = "true";
            }else{
                Console.WriteLine("Invalid response.");
            }
        }while(valid == "false");
        _traitSetting = setting;
    }
    public void getTrait(){
        List<string> traits = _ghosts[_ghost][3];
        List<string> Trait = new List<string>();
        Random random = new Random();
        int i;
        if(_traitSetting == "2"){
            foreach(string trait in traits){
                if (!Trait.Contains(trait))
                {
                    Trait.Add($"{trait}");
                }
            }
        }
        else if(_traitSetting == "1")
        {
            int max = traits.Count();
            i = random.Next(0, max);
            Trait.Add(traits[i]);
            do{
                i = random.Next(0, max);
            }while (Trait.Contains(traits[i]));
            Trait.Add(traits[i]);
        }
        else if (_traitSetting == "0")
        {
        }
        _ghosts[_ghost][3] = Trait;
    }
    public override void Settings(){
        string setting;
        do{
        Console.WriteLine("Which setting?");
        Console.WriteLine("1. Evidence");
        Console.WriteLine("2. Hunt");
        Console.WriteLine("3. Speed");
        Console.WriteLine("4. Trait");
        Console.WriteLine("0. Start");
        setting = Console.ReadLine();
        if (setting == "1"){
            setEvidence();
        }else if (setting == "2"){
            setHunt();
        }else if (setting == "3"){
            setSpeed();
        }else if (setting == "4"){
            setTrait();
        }else if (setting != "0"){
            Console.WriteLine("Invalid response.");
        }
        }while(setting != "0");
        getEvidence();
        getHunt();
        getSpeed();
        getTrait();
    }
    public override int Play()
    {
        Settings();
        Console.WriteLine($"The ghost is {_ghost}");
        int guessCount;
        Console.WriteLine($"This ghost has these characteristics:");
        guessCount = Guesses(_ghost);
        Console.WriteLine($"That took you {guessCount} guesses.");
        return guessCount;
    }
    public override int Guesses(string ghost)
    {
        string guess;
        List<string> guesses = new List<string>();
        int guessCount = 0;
        do{
            Data(_ghost, _ghost);
            guessCount += 1;
            guess = Console.ReadLine();
            guess = guess.ToLower();
            guesses.Add(guess);
        }while(guess != ghost);
        return guessCount;
    }
    public override void Data(string ghost, string guess){
        List<List<string>> stats = _ghosts[_ghost];
        Random random = new Random();
        if (_evidenceSetting != "0"){
            Console.Write($"Evidences: ");
                List<string> evidences = new List<string>();
                foreach(string evidence in stats[0]){
                    if (!evidences.Contains(evidence))
                        {
                            evidences.Add(evidence);
                        }
                }
                foreach(string evidence in evidences){
                    Console.Write($"{evidence}, ");
                }
                Console.Write($"\n");
        }
        if (_huntSetting != "2"){
            int hunts = int.Parse(stats[1][0]);
            int hunt = random.Next(0, hunts);
            Console.WriteLine($"It hunted at: {hunt}");
        }
        if (_speedSetting != "2"){
            float min = float.Parse(stats[2][0]);
            float max = float.Parse(stats[2][1]);
            float speed = min + (float)random.NextDouble() * (max - min);
            Console.WriteLine($"It moved at this speed: {speed.ToString("0.00")}");
        }
        if (_evidenceSetting != "0"){
            Console.Write($"Traits: ");
            foreach(string trait in stats[3]){
                    Console.Write($"{trait}, ");
            }
        }
    }
}