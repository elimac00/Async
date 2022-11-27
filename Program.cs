namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrintToWindow().Result);
        }

        static async Task<string> PrintToWindow()
        {
            return await File.ReadAllTextAsync("TextFile.txt");
        }
    }
}