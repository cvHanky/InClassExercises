namespace Pr03_csharpdata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Beregn arealet af et rektangel.\nIndtast højde: ");
            string heightString = Console.ReadLine();
            Console.Write("Indtast bredde: ");
            string widthString = Console.ReadLine();

            if (int.TryParse(heightString, out int heightInt) && int.TryParse(widthString, out int widthInt))
            {
                Console.WriteLine("Arealet af rektanglet er " + (heightInt * widthInt) + ".");
            }
            else
            {
                Console.WriteLine("Noget gik galt.\nPrøv igen.");
            }

            Console.ReadKey();
        }
    }
}