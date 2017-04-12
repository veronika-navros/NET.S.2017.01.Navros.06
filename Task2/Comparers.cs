using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Provides functionality for sorting integer array in rows' sum ascending order
    /// </summary>
    public class ComparerBySumAsc : IComparer<int[]>
    {
        /// <summary>
        /// Compares integer array by rows' sum
        /// </summary>
        /// <param name="array1">First array for comparing</param>
        /// <param name="array2">Second array for comparing</param>
        /// <returns>1 if first array's elements sum is bigger than the second, otherwise 0</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Compare(int[] array1, int[] array2)
        {
            if (array1 == null || array2 == null)
                throw new ArgumentNullException();

            return array1.Sum() >= array2.Sum() ? 1 : 0;
        }
    }

    /// <summary>
    /// Provides functionality for sorting integer array in rows' sum descending order
    /// </summary>
    public class CompareBySumDesc : IComparer<int[]>
    {
        /// <summary>
        /// Compares integer array by rows' sum
        /// </summary>
        /// <param name="array1">First array for comparing</param>
        /// <param name="array2">Second array for comparing</param>
        /// <returns>1 if first array's elements sum is less than the second, otherwise 0</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Compare(int[] array1, int[] array2)
        {
            if (array1 == null || array2 == null)
                throw new ArgumentNullException();

            return array1.Sum() <= array2.Sum() ? 1 : 0;
        }
    }

    /// <summary>
    /// Provides functionality for sorting integer array in rows' maximum elements ascending order
    /// </summary>
    public class CompareByMaxElementAsc : IComparer<int[]>
    {
        /// <summary>
        /// Compares integer array by rows' maximum elements
        /// </summary>
        /// <param name="array1">First array for comparing</param>
        /// <param name="array2">Second array for comparing</param>
        /// <returns>1 if first array's maximum element is bigger than the second, otherwise 0</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Compare(int[] array1, int[] array2)
        {
            if (array1 == null || array2 == null)
                throw new ArgumentNullException();

            return array1.Max() > array2.Max() ? 1 : 0;
        }
    }

    /// <summary>
    /// Provides functionality for sorting integer array in rows' maximum elements descending order
    /// </summary>
    public class CompareByMaxElementDesc : IComparer<int[]>
    {
        /// <summary>
        /// Compares integer array by rows' maximum elements
        /// </summary>
        /// <param name="array1">First array for comparing</param>
        /// <param name="array2">Second array for comparing</param>
        /// <returns>1 if first array's maximum element is less than the second, otherwise 0</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Compare(int[] array1, int[] array2)
        {
            if (array1 == null || array2 == null)
                throw new ArgumentNullException();

            return array1.Max() < array2.Max() ? 1 : 0;
        }
    }

    /// <summary>
    /// Provides functionality for sorting integer array in rows' minimum elements ascending order
    /// </summary>
    public class CompareByMinElementAsc : IComparer<int[]>
    {
        /// <summary>
        /// Compares integer array by rows' minimum elements
        /// </summary>
        /// <param name="array1">First array for comparing</param>
        /// <param name="array2">Second array for comparing</param>
        /// <returns>1 if first array's minimum element is bigger than the second, otherwise 0</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Compare(int[] array1, int[] array2)
        {
            if (array1 == null || array2 == null)
                throw new ArgumentNullException();

            return array1.Min() > array2.Min() ? 1 : 0;
        }
    }

    /// <summary>
    /// Provides functionality for sorting integer array in rows' minimum elements descending order
    /// </summary>
    public class CompareByMinElementDesc : IComparer<int[]>
    {
        /// <summary>
        /// Compares integer array by rows' minimum elements
        /// </summary>
        /// <param name="array1">First array for comparing</param>
        /// <param name="array2">Second array for comparing</param>
        /// <returns>1 if first array's minimum element is less than the second, otherwise 0</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Compare(int[] array1, int[] array2)
        {
            if (array1 == null || array2 == null)
                throw new ArgumentNullException();

            return array1.Min() < array2.Min() ? 1 : 0;
        }
    }
}
