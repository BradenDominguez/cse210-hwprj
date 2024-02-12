class FileWriter
{
    public static void WriteFile(string path, Dictionary<string, List<string>> content)
    {
    File.WriteAllText(path, String.Empty);
    using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine($"Name,GoalType,Description,Completion,Score");
        foreach (string key in content.Keys)
        {
            writer.Write($"{key}");
            List<string> values = content[key];
            foreach (string value in values)
            {
                writer.Write($",{value}");
            }
            writer.Write($"\n");
        }
        }
    Console.WriteLine($"Content has been written to {path}");
    }

}
