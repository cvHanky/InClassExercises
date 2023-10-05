namespace Pr07_menusystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu("Min fantastiske menu");

            // First menu item
            mainMenu.AddMenuItem("1. Gør dit");

            // Second menu item
            mainMenu.AddMenuItem("2. Gør dat");

            // Third menu item
            mainMenu.AddMenuItem("3. Gør noget");

            // Last menu item
            mainMenu.AddMenuItem("4. Få svaret på livet, universet og alting");

            mainMenu.AddMenuItem("skrt skrt");

            mainMenu.Show();

            mainMenu.SelectMenuItem(int.Parse(Console.ReadLine()));


            Console.WriteLine("\nPress any button to continue...");
            Console.ReadKey();
        }

    }
}