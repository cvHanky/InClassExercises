namespace TotallySafeLib
{
    public class TotallySafe
    {
        public static double Divider(int number)
        {
            return 7 / number;
        }
        public static int StringToInt(string stringToConvert)
        {
            return int.Parse(stringToConvert);
        }
        public static int? GetValueAtPosition(int positionInArray)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            int? dinMor = null;
            try
            {
                dinMor = intArray[positionInArray];
            }
            catch (IndexOutOfRangeException e)
            {
                if (positionInArray < 0)
                    throw new NegativeIndexOutOfRange("Din mor er gjort", e);
                else
                    throw new IndexOutOfRangeException("Din mor er ikke gjort", e);

            }
            return dinMor;
        }
    }
}
