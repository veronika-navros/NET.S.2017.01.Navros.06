﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Represents various types of bubble sorting for jagged integer arrays
    /// </summary>
    public static class BubbleSort
    {
        #region Public Members

        /// <summary>
        /// Sorts jagged integer array in rows' sums ascending order
        /// </summary>
        /// <param name="array">Array for sorting</param>
        public static void OrderBySumAsc(int[][] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (!array.Any())
                throw new ArgumentException();

            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if(array[j].Sum() > array[j + 1].Sum())
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        /// <summary>
        /// Sorts jagged integer array in rows' sums descending order
        /// </summary>
        /// <param name="array">Array for sorting</param>
        public static void OrderBySumDesc(int[][] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (!array.Any())
                throw new ArgumentException();

            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j].Sum() < array[j + 1].Sum())
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        /// <summary>
        /// Sorts jagged integer array in rows' maximum elements ascending order
        /// </summary>
        /// <param name="array">Array for sorting</param>
        public static void OrderByMaxElementAsc(int[][] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (!array.Any())
                throw new ArgumentException();

            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j].Max() > array[j + 1].Max())
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        /// <summary>
        /// Sorts jagged integer array in rows' maximum elements descending order
        /// </summary>
        /// <param name="array">Array for sorting</param>
        public static void OrderByMaxElementDesc(int[][] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (!array.Any())
                throw new ArgumentException();

            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j].Max() < array[j + 1].Max())
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        /// <summary>
        /// Sorts jagged integer array in rows' minimum elements ascending order
        /// </summary>
        /// <param name="array">Array for sorting</param>
        public static void OrderByMinElementAsc(int[][] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (!array.Any())
                throw new ArgumentException();

            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j].Min() > array[j + 1].Min())
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        /// <summary>
        /// Sorts jagged integer array in rows' minimum elements descending order
        /// </summary>
        /// <param name="array">Array for sorting</param>
        public static void OrderByMinElementDesc(int[][] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (!array.Any())
                throw new ArgumentException();

            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j].Min() < array[j + 1].Min())
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        #endregion

        #region Private Members

        /// <summary>
        /// Swaps 2 integer arrays
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        static void Swap(ref int[] number1, ref int[] number2)
        {
            int[] temp = number1;
            number1 = number2;
            number2 = temp;
        }

        #endregion
    }
}
