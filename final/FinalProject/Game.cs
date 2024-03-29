abstract class Game
{
    protected Dictionary<string, List<List<string>>> _ghosts;
    protected string _ghost;
    protected int guessCount;
    public Game(Dictionary<string, List<List<string>>> ghosts, string ghost)
    {
        _ghosts = ghosts;
        _ghost = ghost;
    }
    public abstract void Settings();
    public abstract int Play();
    public abstract int Guesses(string _ghost);
    public abstract void Data(string ghost, string guess);
    
}