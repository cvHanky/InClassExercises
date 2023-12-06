namespace Pr33_delegates_bonusapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            int c = 6;
            int d = 10;

            if (a == 1 && b == 3 && c == 5 || d == 10)
                Console.WriteLine("it works!");
            else Console.WriteLine("no!");

            Console.ReadKey();
        }
    }
}