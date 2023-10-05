using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr14_loops
{
    public class IntArrayHelper
    {


        public void SortAscending(int[] intArray)
        {
            int temp = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = 1+i;j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
        }

        public void SortAscendingAndReverse(int[] intArray)
        {
            int temp = 0;

            for (int i = intArray.Length-1; i >= 0; i--)
            {
                for (int j = i-1; j >= 0; j--)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
        }
    }
}
