namespace Test123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string nameString = Console.ReadLine();
            Console.WriteLine("Your chosen name is: " + nameString);
            Console.Write("Age: ");
            string ageString = Console.ReadLine();
            int ageInt = int.Parse(ageString);
            Console.WriteLine("Your chosen age is: " + ageInt);

            if (ageInt is int)
                Console.WriteLine("Your age is a number!");
            else
                Console.WriteLine("Your age is unfortunately not a number.");

            Console.WriteLine(nameString + " is not " + (ageInt - 10) + " years old.");
        }
    }
}