namespace Pr03_csharpdata_tekststring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv en vilkårlig sætning: ");
            string sætningString = Console.ReadLine();

            Console.WriteLine("Længden af din sætning er: " + sætningString.Length);

            Console.Write("Skriv en vilkårlig sætninger der indeholder \"bingbong\": ");
            string bingbongString = Console.ReadLine();

            Console.WriteLine("En del af din sætning er:" + bingbongString.Substring(2,5));

            Console.ReadKey();
        }
    }
}