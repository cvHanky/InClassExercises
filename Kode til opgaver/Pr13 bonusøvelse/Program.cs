namespace Pr13_bonusøvelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (JumpHelper.MakeAJump(0, 3, 4, 2) == "NO")
                Console.WriteLine("damnit");

            Console.ReadKey();
        }
    }
}