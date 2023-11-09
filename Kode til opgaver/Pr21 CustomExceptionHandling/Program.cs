using TotallySafeLib;

namespace Pr21_CustomExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? skrt = TotallySafe.GetValueAtPosition(17);
            //try
            //{
            //    int posValue = TotallySafe.GetValueAtPosition(8);
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.ReadKey();
            //}
            //Console.Clear();
            //try
            //{
            //    Double value = TotallySafe.Divider(0);
            //}
            //catch (DivideByZeroException e)
            //{

            //    Console.WriteLine(e.Message);
            //    Console.ReadKey();
            //}
            //Console.Clear();
            //try
            //{
            //    int b = TotallySafe.StringToInt("l");
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.ReadKey();
            //}
            Console.Clear();
            Console.ReadKey();
        }
    }
}