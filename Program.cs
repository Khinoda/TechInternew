namespace TechnicalInterview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\input.txt";
            var lines = File.ReadAllLines(path);
            Array.ForEach(lines, line => Console.WriteLine(line));
            Console.ReadKey();
        }
    }
}