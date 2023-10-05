namespace Pr03_csharpdata_hældningsberegner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beregn hældning af en linje mellem startpunkt og slutpunkt.\nIndtast startpunkt (x,y): ");
            string startpunktString = Console.ReadLine();
            Console.WriteLine("Indtast slutpunkt (x,y): ");
            string slutpunktString = Console.ReadLine();

            double.TryParse(startpunktString.Substring(0, startpunktString.IndexOf(",")), out double startXpunktInt);
            double.TryParse(startpunktString.Substring(startpunktString.IndexOf(",") + 1), out double startYpunktInt);

            double.TryParse(slutpunktString.Substring(0, slutpunktString.IndexOf(",")), out double slutXpunktInt);
            double.TryParse(slutpunktString.Substring(slutpunktString.IndexOf(",") + 1), out double slutYpunktInt);

            double hældningFloat = ((slutYpunktInt - startYpunktInt) / (slutXpunktInt - startXpunktInt));

            Console.WriteLine("Hældningen af linjen mellem de to punkter er: " + hældningFloat);


            Console.ReadKey();
        }
    }
}