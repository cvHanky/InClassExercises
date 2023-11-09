namespace Pr22_IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("pongping.txt");
            try
            {
                sw.WriteLine("Goddag, mit navn er pongping. Jeg kommer fra det grønne land af pingpong bolde");
            }
            finally
            {
                sw.Dispose();
            }

            using (StreamReader sr = new StreamReader("pongping.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}