using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Policy;

class GameTrait : Game
{
    public GameTrait(Dictionary<string, List<List<string>>> ghosts, string ghost) : base(ghosts, ghost)
    {
    }
    public override void Settings(){
        // setEvidence();

        List<string> Hunt = _ghosts[_ghost][1];
        List<string> Speed = _ghosts[_ghost][2];
        List<string> Trait = _ghosts[_ghost][3];
    }
    public override int Play()
    {
        Console.WriteLine($"The ghost is {_ghost}");
        guessCount = Guesses(_ghost);
        Console.WriteLine($"That took you {guessCount} guesses.");
        return guessCount;
    }
    public override int Guesses(string ghost)
    {
        string guess;
        List<string> guesses = new List<string>();
        int guessCount = 0;
        List<List<string>> stats = _ghosts[_ghost];
        HashSet<int> numbers = new HashSet<int>();
        Random random = new Random();
        int i;
        int i2;
        int max = stats[4].Count();
        i = random.Next(0, max);
        numbers.Add(i);
        do
        {
            i2 = random.Next(0, max);
        } while (numbers.Contains(i2));
        numbers.Add(i2);
        do{
            Console.WriteLine($"This ghost {stats[4][i]}");
            if (guessCount > 3){
                Console.WriteLine($"and {stats[4][i2]}");
            }
            guessCount += 1;
            guess = Console.ReadLine();
            guess = guess.ToLower();
            guesses.Add(guess);
        }while(guess != ghost);
        return guessCount;
    }
    public override void Data(string ghost, string guess){
    }
}