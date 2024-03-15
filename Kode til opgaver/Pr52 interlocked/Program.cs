namespace Pr52_interlocked
{
    class Program
    {
        private static object _myLock = new object();
        private const int ITERATIONS = 1000000;
        private Int64 _number;
        public Int64 Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            Number = 0;
            Thread adder = new Thread(Add);
            Thread subtractor = new Thread(Subtract);
            adder.Start();
            subtractor.Start();
            adder.Join();
            subtractor.Join();
            Console.Write($"Number: {Number}. \t\tPress any key...");
            Console.ReadKey();
        }

        private void Add()
        {
            for (int i = 0; i < ITERATIONS; i++)
            {
                Interlocked.Increment(ref _number);
            }
        }

        private void Subtract()
        {
            for (int i = 0; i < ITERATIONS; i++)
            {
                Interlocked.Decrement(ref _number);
            }
        }
    }

}
