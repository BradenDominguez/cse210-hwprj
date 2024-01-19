using System;
using System.IO;
class FileWriter
{
    public static void WriteFile(string path, string content)
    {
    using (StreamWriter writer = new StreamWriter(path, true))
        {
        writer.WriteLine(content);
        }
    Console.WriteLine($"Content has been written to {path}");
    }
}