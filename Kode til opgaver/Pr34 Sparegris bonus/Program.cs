namespace Pr34_Sparegris_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sparegris piggy = new Sparegris();
            piggy.AmountChanged += piggy.Update;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Welcome to piggy!\nPiggy's current amount is: {piggy.Amount}\n\nPlease insert an amount: ");
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    piggy.InsertAmount(result);
                    Console.WriteLine("Press any button to continue...");
                    Console.ReadKey();
                }

            }
        }
    }
}