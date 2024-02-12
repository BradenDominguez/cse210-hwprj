class FileReader
{
    public static string ReadFile(string path)
    {
    using (StreamReader reader = new StreamReader(path))
        {
        string content = reader.ReadToEnd();
        Console.WriteLine($"Goals loaded from {path}");
        return content;
        }
    }
}