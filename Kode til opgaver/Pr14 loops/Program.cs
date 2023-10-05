namespace Pr14_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntArrayHelper intArrayHelper = new IntArrayHelper();
            
            int[] intArray = { 6, 1, 7, 2, 20, 4 };
            intArrayHelper.SortAscending(intArray);

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            intArrayHelper.SortAscendingAndReverse(intArray);

            Console.WriteLine("\n\n");

            for (int i = 0; i < intArray.Length; i++)
                Console.WriteLine(intArray[i]);

            Console.ReadKey();
        }
    }
}