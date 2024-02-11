namespace testestestestestse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.TryParse("2023-03-04  21:00", out DateTime result) == false)
            {
                Console.WriteLine("peepee");
            }
            Console.WriteLine(result);


            Console.ReadKey();
        }
    }
}
