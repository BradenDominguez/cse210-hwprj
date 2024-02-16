using System.Data;
using System.Runtime.InteropServices;

class GameClassic : Game
{
    public GameClassic(Dictionary<string, List<List<string>>> ghosts, string ghost) : base(ghosts, ghost)
    {
    }
    public override int Play()
    {
        int guessCount = 0;
        Console.WriteLine($"The ghost is {_ghost}");
        guessCount = Guesses(_ghost);
        Console.WriteLine($"{_ghost} you {guessCount} guesses.");
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
            Data(guess, ghost);
            guesses.Add(guess);
        }while(guess != ghost);
        return guessCount;
    }
    public override void Data(string ghost, string guess){
            Console.ForegroundColor = ConsoleColor.Green;
            if (_ghosts.ContainsKey(guess)){
                List<List<string>> guessStats = _ghosts[guess];
                List<List<string>> actualStats = _ghosts[ghost];
                // Console.WriteLine($"Evidences: {stats[0][0]}, {stats[0][1]}, {stats[0][2]}; Favorite Evidence: {stats[0][3]}");
                Console.Write($"Evidences: ");
                foreach(string evidence in guessStats[0]){
                    if (new List<string> {actualStats[0][0], actualStats[0][1], actualStats[0][2], actualStats[0][3]}.Contains(evidence))
                    {
                        Console.Write($"{evidence}");
                        if (evidence != guessStats[0][3]){
                            Console.Write($", ");
                        }
                    }
                    Console.Write($"\n");
                }
                // Console.ForegroundColor = ConsoleColor.Red;
                // Console.WriteLine($"Max Hunt Threshold: {stats[1][0]}; Actual Hunt Threshold: {stats[1][1]}");
                Console.Write($"Max Hunt Threshold: ");
                int guessHunt = int.Parse(guessStats[1][0]);
                int actualHunt = int.Parse(actualStats[1][0]);
                Console.WriteLine(guessHunt);
                Console.WriteLine(actualHunt);
                if (guessHunt < actualHunt){
                    Console.Write("Higher");
                }else if (guessHunt > actualHunt){
                    Console.Write("Lower");
                }else if (guessHunt <= actualHunt){
                    Console.Write("Same Level");
                }
                // Console.ForegroundColor = ConsoleColor.DarkMagenta;
                // Console.WriteLine($"Min Speed: {stats[2][0]}; Max Speed: {stats[2][1]}");
                // Console.ForegroundColor = ConsoleColor.Yellow;
                // Console.WriteLine($"Traits: {stats[3][0]}, {stats[3][1]}, {stats[3][2]}, {stats[3][3]}");
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