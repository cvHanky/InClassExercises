namespace Pr51_area51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Go);    // Metode anvendes som argument til thread

            Thread t2 = new Thread((object? objMessage) =>   // Lambda-udtryk anvendes som argument
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(objMessage?.ToString());
                }
            });

            Thread t3 = new Thread(delegate(object? objMessage)   // Anonym metode anvendes som argument
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(objMessage?.ToString());
                }
            });

            t1.Start("Hello world (metode)");
            t1.Join();
            t2.Start("Hello world (lambda)");
            t2.Join();
            t3.Start("Hello world (anonymous)");
            t3.Join();
            Console.ReadKey();
        }

        static void Go(object? msgObject)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(msgObject?.ToString());
            }
        }
    }
}
