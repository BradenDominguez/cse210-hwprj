public class CSV
{
    public static Dictionary<string, List<string>> CSVToDict(Dictionary<string, List<string>> goals, string content)
    {
        String[] lines = content.Split("\n", StringSplitOptions.RemoveEmptyEntries);
        foreach (string line in lines.Skip(1))
        {
            String[] words = line.Split(",", StringSplitOptions.RemoveEmptyEntries);
            string key = words[0];
            string[] values = words[1..];
            if (!goals.ContainsKey(key))
            {
                goals[key] = new List<string>();
            }
            foreach (string value in values)
            {
                goals[key].Add(value);
            }
        }
        return goals;
    }
}
