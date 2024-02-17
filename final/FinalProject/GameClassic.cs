using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Policy;

class GameClassic : Game
{
    public GameClassic(Dictionary<string, List<List<string>>> ghosts, string ghost) : base(ghosts, ghost)
    {
    // _evidenceSetting = "3";
    // _huntSetting = "1";
    // _speedSetting = "1";
    // _traitSetting = "4";
    }
    public override void Settings(){
        // List<string> Evidence = new List<string>();
        // RandomGenerator random = new RandomGenerator();
        // int i;
        // if(_ghost == "mimic"){
        //     Evidence.Add(_ghosts[_ghost][0][3]);
        // }
        // if(_evidenceSetting == "3"){
        //     Evidence.Add(_ghosts[_ghost][0][0]);
        //     Evidence.Add(_ghosts[_ghost][0][1]);
        //     Evidence.Add(_ghosts[_ghost][0][2]);
        //     _ghosts[_ghost][0] = Evidence;
        // }else if(_evidenceSetting == "2"){
        //     if (_ghosts[_ghost][0][3] != "None"){
        //         Evidence.Add(_ghosts[_ghost][0][3]);
        //         do{
        //             i = random.NextUniqueNumber(1,3);
        //         }while (!Evidence.Contains(_ghosts[_ghost][0][i]));
        //             Evidence.Add(_ghosts[_ghost][0][i]);
        //     }else{
        //         i = random.NextUniqueNumber(1,3);
        //         Evidence.Add(_ghosts[_ghost][0][i]);
        //         do{
        //             i = random.NextUniqueNumber(1,3);
        //         }while (!Evidence.Contains(_ghosts[_ghost][0][i]));
        //         Evidence.Add(_ghosts[_ghost][0][i]);
        //     }
            
        // }else if(_evidenceSetting == "1"){
        //     if (_ghosts[_ghost][0][3] != "None"){
        //         Evidence.Add(_ghosts[_ghost][0][3]);
        //     }else{
        //         i = random.NextUniqueNumber(1,3);
        //         Evidence.Add(_ghosts[_ghost][0][i]);
        //     }
        // }else if(_evidenceSetting == "0"){
        // }
        // _ghosts[_ghost][0] = Evidence;
            
        
        // List<string> Hunt = _ghosts[_ghost][1];
        // List<string> Speed = _ghosts[_ghost][2];
        // List<string> Trait = _ghosts[_ghost][3];
    }
    // public override void EvidenceSetting(){
    //     string valid = "false";
    //     string setting;
    //     do{
    //     Console.WriteLine("Input a number:");
    //     Console.WriteLine("3. Three Evidence");
    //     Console.WriteLine("2. Two Evidence");
    //     Console.WriteLine("1. One Evidence");
    //     Console.WriteLine("0. Zero Evidence");
    //     setting = Console.ReadLine();
    //     if (setting == "3" || setting == "2"|| setting == "1"|| setting == "0"){
    //         valid = "true";
    //     }else{
    //         Console.WriteLine("Invalid response.");
    //     }
    //     }while(valid == "false");
    //     _evidenceSetting = setting;
    // }
    // public override void HuntSetting(){
    //     string valid = "false";
    //     string setting;
    //     do{
    //     Console.WriteLine("Input a number:");
    //     Console.WriteLine("1. Enabled");
    //     Console.WriteLine("2. Disabled");
    //     setting = Console.ReadLine();
    //     if (setting == "1" || setting == "2"){
    //         valid = "true";
    //     }else{
    //         Console.WriteLine("Invalid response.");
    //     }
    //     }while(valid == "false");
    //     _huntSetting = setting;
    // }
    // public override void SpeedSetting(){
    //     string valid = "false";
    //     string setting = "3";
    //     do{
    //     Console.WriteLine("Input a number:");
    //     Console.WriteLine("1. Min and Max Speed Enabled");
    //     Console.WriteLine("2. Min Speed Enabled");
    //     Console.WriteLine("3. Max Speed Enabled");
    //     Console.WriteLine("4. Both Disabled");
    //     setting = Console.ReadLine();
    //     if (setting == "1" || setting == "2" || setting == "3" || setting == "4"){
    //         valid = "true";
    //     }else{
    //         Console.WriteLine("Invalid response.");
    //     }
    //     }while(valid == "false");
    //     _speedSetting = setting;
    // }
    // public override void TraitSetting(){
    //     string valid = "false";
    //     string setting = "3";
    //     do{
    //     Console.WriteLine("Input a number:");
    //     Console.WriteLine("4. Four traits");
    //     Console.WriteLine("3. Three Traits");
    //     Console.WriteLine("2. Two Traits");
    //     Console.WriteLine("1. Once Traits");
    //     Console.WriteLine("0. Zero Traits");
    //     setting = Console.ReadLine();
    //     if (setting == "1" || setting == "2" || setting == "3" || setting == "4"|| setting == "0"){
    //         valid = "true";
    //     }else{
    //         Console.WriteLine("Invalid response.");
    //     }
    //     }while(valid == "false");
    //     _traitSetting = setting;
    // }
    public override int Play()
    {
        Settings();
        int guessCount;
        // Console.WriteLine($"The ghost is {_ghost}");
        Console.WriteLine($"Guess a ghost:");
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
            guessCount += 1;
            guess = Console.ReadLine();
            guess = guess.ToLower();
            Data(ghost, guess);
            guesses.Add(guess);
        }while(guess != ghost);
        return guessCount;
    }
    public override void Data(string ghost, string guess){
            if (_ghosts.ContainsKey(guess)){
                List<List<string>> guessStats = _ghosts[guess];
                List<List<string>> actualStats = _ghosts[ghost];
                // Console.ForegroundColor = ConsoleColor.Green;
                // Console.WriteLine($"Evidences: {stats[0][0]}, {stats[0][1]}, {stats[0][2]}; Favorite Evidence: {stats[0][3]}");
                Console.Write($"Evidences: ");
                foreach(string evidence in guessStats[0]){
                    if (new List<string> {actualStats[0][0], actualStats[0][1], actualStats[0][2], actualStats[0][3]}.Contains(evidence))
                    {
                        if (evidence != "None")
                        {
                        Console.Write($"{evidence}, ");
                        }
                    }
                }
                Console.Write($"\n");
                // Console.ForegroundColor = ConsoleColor.Red;
                // Console.WriteLine($"Max Hunt Threshold: {stats[1][0]}; Actual Hunt Threshold: {stats[1][1]}");
                Console.Write($"Max Hunt Threshold: ");
                int guessHunt = int.Parse(guessStats[1][0]);
                int actualHunt = int.Parse(actualStats[1][0]);
                if (guessHunt < actualHunt){
                    Console.Write("Higher");
                }else if (guessHunt > actualHunt){
                    Console.Write("Lower");
                }else if (guessHunt <= actualHunt){
                    Console.Write("Same Level");
                }
                Console.Write($"\n");
                // Console.ForegroundColor = ConsoleColor.DarkMagenta;
                // Console.WriteLine($"Min Speed: {stats[2][0]}; Max Speed: {stats[2][1]}");
                Console.Write($"Min Speed: ");
                float guessMinSpeed = float.Parse(guessStats[2][0]);
                float actualMinSpeed = float.Parse(actualStats[2][0]);
                if (guessMinSpeed < actualMinSpeed){
                    Console.Write("Higher");
                }else if (guessMinSpeed > actualMinSpeed){
                    Console.Write("Lower");
                }else if (guessMinSpeed <= actualMinSpeed){
                    Console.Write("Same Speed");
                }
                Console.Write($"\n");
                Console.Write($"Max Speed: ");
                float guessMaxSpeed = float.Parse(guessStats[2][1]);
                float actualMaxSpeed = float.Parse(actualStats[2][1]);
                if (guessMaxSpeed < actualMaxSpeed){
                    Console.Write("Higher");
                }else if (guessMaxSpeed > actualMaxSpeed){
                    Console.Write("Lower");
                }else if (guessMaxSpeed <= actualMaxSpeed){
                    Console.Write("Same Speed");
                }
                Console.Write($"\n");
                // Console.ForegroundColor = ConsoleColor.Yellow;
                // Console.WriteLine($"Traits: {stats[3][0]}, {stats[3][1]}, {stats[3][2]}, {stats[3][3]}");
                Console.Write($"Traits: ");
                foreach(string evidence in guessStats[3]){
                    if (new List<string> {actualStats[3][0], actualStats[3][1], actualStats[3][2], actualStats[3][3]}.Contains(evidence))
                    {
                        if (evidence != "None")
                        {
                        Console.Write($"{evidence}, ");
                        }
                    }
                }
                Console.Write($"\n");
            }else{
                Console.WriteLine("Not a valid ghost.");
            }
    }
    public override string Completion(){
        return "";
    }
    public override string Scoring(int score){
        return "";
    }
}