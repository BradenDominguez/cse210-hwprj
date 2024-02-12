using System.Text;
class FileWriter
{
    public static void WriteFile(string path, string content)
    {
    using (StreamWriter writer = new StreamWriter(path, true))
        {
        string code = StringToBinary(content);
        writer.WriteLine(code);
        }
    Console.WriteLine($"Content has been written to {path}");
    }
    // This converts the message to binary so no on else can read it
    static string StringToBinary(string input)
    {
        byte[] bytes = Encoding.ASCII.GetBytes(input);
        return string.Join(" ", bytes.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
    }
}
