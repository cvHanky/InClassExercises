namespace Pr21_tusindfryd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.AddToList("Blomst", 120, 2, 5);

            Console.ReadKey();
        }
    }
}