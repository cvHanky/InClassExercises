namespace Pr02_conditionals_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min fantastiske menu: \n \n1. Gør dit. \n2. Gør dat. \n3. Gør noget. \n4. Få svaret på livet, universet og alting. \n \n(Tryk menupunkt 1, 2, 3 eller 4)");
            int menupunktInt = int.Parse(Console.ReadLine());

            switch (menupunktInt) 
            {
                case 1:
                    Console.WriteLine("Punkt 1 er valgt. Gør dit.");
                    break;
                case 2:
                    Console.WriteLine("Punkt 2 er valgt. Gør dat.");
                    break;
                case 3:
                    Console.WriteLine("Punkt 3 er valgt. Gør noget.");
                    break;
                case 4:
                    Console.WriteLine("Punkt 4 er valgt. 42.");
                    break;
                default:
                    Console.WriteLine("Ikke et gyldigt valg. Prøv igen.");
                    break;
            }

            Console.ReadKey();
        }
    }
}