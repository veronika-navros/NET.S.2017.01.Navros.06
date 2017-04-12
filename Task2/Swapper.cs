using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Provides functionality to swap two integer arrays
    /// </summary>
    public class Swapper
    {
        /// <summary>
        /// Swaps 2 integer arrays
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        internal static void Swap(ref int[] number1, ref int[] number2)
        {
            int[] temp = number1;
            number1 = number2;
            number2 = temp;
        }
    }
}
