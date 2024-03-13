namespace BonusApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
            Console.WriteLine(consoleKeyInfo.Key.ToString());

            Console.ReadKey();
        }
    }
}