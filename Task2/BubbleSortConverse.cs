using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Represents bubble sorting for jagged integer arrays
    /// </summary>
    public class BubbleSortConverse
    {
        #region Public members

        /// <summary>
        /// Sorts jagged integer array using the specified comparison
        /// </summary>
        /// <param name="comparison">Comparison instance</param>
        /// <param name="array">Array for sorting</param>   
        ///  /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static void Sort(Comparison<int[]> comparison, int[][] array)
        {
            if (array == null || comparison == null)
                throw new ArgumentNullException();
            if (!array.Any())
                throw new ArgumentException();

            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (comparison(array[j], array[j + 1]) > 0)
                        Swapper.Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        /// <summary>
        /// Sorts jagged integer array using the specified comparer
        /// </summary>
        /// <param name="comparer">Comparer instance</param>
        /// <param name="array">Array for sorting</param>
        ///  /// <exception cref="ArgumentNullException"></exception>
        public static void Sort(IComparer<int[]> comparer, int[][] array)
        {
            if (comparer == null)
                throw new ArgumentNullException();

            Sort(comparer.Compare, array);
        }

        #endregion
    }
}
