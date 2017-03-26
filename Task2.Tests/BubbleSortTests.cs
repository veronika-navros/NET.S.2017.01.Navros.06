using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Task2.Tests
{
    [TestFixture]
    public class BubbleSortTests
    {
        #region OrderBySumAsc Tests

        public static IEnumerable<int[][][]> OrderBySumAscData
        {
            get
            {
                yield return new [] { new[]
                {
                    new[] {5, 2, 7, 0, 1},
                    new[] {8, 3},
                    new[] {5, 4, 8},
                    new[] {4}
                },
                new[]
                {
                    new[] { 4 },
                    new[] { 8, 3 },
                    new[]  {5, 2, 7, 0, 1 },
                    new[] { 5, 4, 8 },
                }};

                yield return new[] { new[]
                {
                    new[] {9, 0, 6},
                    new[] {7},
                    new[] {8, 8},
                    new[] {6, 2, 6, 6, 7}
                },
                new[]
                {
                    new[] {7},
                    new[] {9, 0, 6},
                    new[] {8, 8},
                    new[] {6, 2, 6, 6, 7}
                }};

                yield return new[] { new[]
                {
                    new[] {1, 9},
                    new[] {1, 6, 4},
                    new[] {9, 4, 3, 0, 5, 5},
                    new[] {0, 0, 3, 6, 9, 5}
                },
                new[]
                {
                    new[] {1, 9},
                    new[] {1, 6, 4},
                    new[] {0, 0, 3, 6, 9, 5},
                    new[] {9, 4, 3, 0, 5, 5}
                }};
            }
        }

        [Test, TestCaseSource("OrderBySumAscData")]
        public void OrderBySumAsc_ArraySortedByElementsSumInRowAscending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSort.OrderBySumAsc(sourceArray);
            IStructuralEquatable resultArray = testData[1];

            Assert.AreEqual(resultArray.Equals(sourceArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        #endregion

        #region OrderBySumDesc Tests

        public static IEnumerable<int[][][]> OrderBySumDescData
        {
            get
            {
                yield return new[] { new[]
                {
                    new[] {5, 2, 7, 0, 1},
                    new[] {8, 3},
                    new[] {5, 4, 8},
                    new[] {4}
                },
                new[]
                {
                    new[] { 5, 4, 8 },
                    new[]  {5, 2, 7, 0, 1 },
                    new[] { 8, 3 },
                    new[] { 4 },
                }};

                yield return new[] { new[]
                {
                    new[] {9, 0, 6},
                    new[] {7},
                    new[] {8, 8},
                    new[] {6, 2, 6, 6, 7}
                },
                new[]
                {
                    new[] {6, 2, 6, 6, 7},
                    new[] {8, 8},
                    new[] {9, 0, 6},
                    new[] {7}
                }};

                yield return new[] { new[]
                {
                    new[] {1, 9},
                    new[] {1, 6, 4},
                    new[] {9, 4, 3, 0, 5, 5},
                    new[] {0, 0, 3, 6, 9, 5}
                },
                new[]
                {
                    new[] {9, 4, 3, 0, 5, 5},
                    new[] {0, 0, 3, 6, 9, 5},
                    new[] {1, 6, 4},
                    new[] {1, 9},
                }};
            }
        }


        [Test, TestCaseSource("OrderBySumDescData")]
        public void OrderBySumDesc_ArraySortedByElementsSumInRowDescending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSort.OrderBySumDesc(sourceArray);
            IStructuralEquatable resultArray = testData[1];

            Assert.AreEqual(resultArray.Equals(sourceArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        #endregion

        #region OrderByMaxElementAsc Tests

        public static IEnumerable<int[][][]> OrderByMaxElementAscData
        {
            get
            {
                yield return new[] { new[]
                {
                    new[] {5, 2, 7, 0, 1},
                    new[] {8, 3},
                    new[] {5, 4, 8},
                    new[] {4}
                },
                new[]
                {
                    new[] {4},
                    new[] {5, 2, 7, 0, 1},
                    new[] {8, 3},
                    new[] {5, 4, 8}
                }};

                yield return new[] { new[]
                {
                    new[] {9, 0, 6},
                    new[] {7},
                    new[] {8, 8},
                    new[] {6, 2, 6, 6, 7}
                },
                new[]
                {
                    new[] {7},
                    new[] {6, 2, 6, 6, 7},
                    new[] {8, 8},
                    new[] {9, 0, 6}
                }};

                yield return new[] { new[]
                {
                    new[] {1, 9},
                    new[] {1, 6, 4},
                    new[] {9, 4, 3, 0, 5, 5},
                    new[] {0, 0, 3, 6, 9, 5}
                },
                new[]
                {
                    new[] {1, 6, 4},
                    new[] {1, 9},
                    new[] {9, 4, 3, 0, 5, 5},
                    new[] {0, 0, 3, 6, 9, 5},
                }};
            }
        }

        [Test, TestCaseSource("OrderByMaxElementAscData")]
        public void OrderByMaxElementAsc_ArraySortedByMaxElementInRowAscending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSort.OrderByMaxElementAsc(sourceArray);
            IStructuralEquatable resultArray = testData[1];

            Assert.AreEqual(resultArray.Equals(sourceArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        #endregion

        #region OrderByMaxElementDesc Tests

        public static IEnumerable<int[][][]> OrderByMaxElementDescData
        {
            get
            {
                yield return new[] { new[]
                {
                    new[] {5, 2, 7, 0, 1},
                    new[] {8, 3},
                    new[] {5, 4, 8},
                    new[] {4}
                },
                new[]
                {                  
                    new[] {8, 3},
                    new[] {5, 4, 8},
                    new[] {5, 2, 7, 0, 1},
                    new[] {4}
                }};

                yield return new[] { new[]
                {
                    new[] {9, 0, 6},
                    new[] {7},
                    new[] {8, 8},
                    new[] {6, 2, 6, 6, 7}
                },
                new[]
                {
                    new[] {9, 0, 6},
                    new[] {8, 8},
                    new[] {7},
                    new[] {6, 2, 6, 6, 7}
                }};

                yield return new[] { new[]
                {
                    new[] {1, 9},
                    new[] {1, 6, 4},
                    new[] {9, 4, 3, 0, 5, 5},
                    new[] {0, 0, 3, 6, 9, 5}
                },
                new[]
                {
                    new[] {1, 9},
                    new[] {9, 4, 3, 0, 5, 5},
                    new[] {0, 0, 3, 6, 9, 5},
                    new[] {1, 6, 4}
                }};
            }
        }

        [Test, TestCaseSource("OrderByMaxElementDescData")]
        public void OrderByMaxElementDesc_ArraySortedByMaxElementInRowDescending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSort.OrderByMaxElementDesc(sourceArray);
            IStructuralEquatable resultArray = testData[1];

            Assert.AreEqual(resultArray.Equals(sourceArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        #endregion

        #region OrderByMinElementAsc Tests

        public static IEnumerable<int[][][]> OrderByMinElementAscData
        {
            get
            {
                yield return new[] { new[]
                {
                    new[] {5, 2, 7, 0, 1},
                    new[] {8, 3},
                    new[] {5, 4, 8},
                    new[] {4}
                },
                new[]
                {
                    new[] {5, 2, 7, 0, 1},
                    new[] {8, 3},
                    new[] {5, 4, 8},
                    new[] {4}
                }};

                yield return new[] { new[]
                {
                    new[] {9, 0, 6},
                    new[] {7},
                    new[] {8, 8},
                    new[] {6, 2, 6, 6, 7}
                },
                new[]
                {
                    new[] {9, 0, 6},
                    new[] {6, 2, 6, 6, 7},
                    new[] {7},
                    new[] {8, 8}
                }};

                yield return new[] { new[]
                {
                    new[] {1, 9},
                    new[] {1, 6, 4},
                    new[] {9, 4, 3, 0, 5, 5},
                    new[] {0, 0, 3, 6, 9, 5}
                },
                new[]
                {
                    new[] {9, 4, 3, 0, 5, 5},
                    new[] {0, 0, 3, 6, 9, 5},
                    new[] {1, 9},
                    new[] {1, 6, 4}
                }};
            }
        }

        [Test, TestCaseSource("OrderByMinElementAscData")]
        public void OrderByMinElementAsc_ArraySortedByMinElementInRowAscending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSort.OrderByMinElementAsc(sourceArray);
            IStructuralEquatable resultArray = testData[1];

            Assert.AreEqual(resultArray.Equals(sourceArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        #endregion

        #region OrderByMinElementDesc Tests

        public static IEnumerable<int[][][]> OrderByMinElementDescData
        {
            get
            {
                yield return new[] { new[]
                {
                    new[] {5, 2, 7, 0, 1},
                    new[] {8, 3},
                    new[] {5, 4, 8},
                    new[] {4}
                },
                new[]
                {
                    new[] {5, 4, 8},
                    new[] {4},
                    new[] {8, 3},
                    new[] {5, 2, 7, 0, 1}
                }};

                yield return new[] { new[]
                {
                    new[] {9, 0, 6},
                    new[] {7},
                    new[] {8, 8},
                    new[] {6, 2, 6, 6, 7}
                },
                new[]
                {                   
                    new[] {8, 8},
                    new[] {7},
                    new[] {6, 2, 6, 6, 7},
                    new[] {9, 0, 6}
                }};

                yield return new[] { new[]
                {
                    new[] {1, 9},
                    new[] {1, 6, 4},
                    new[] {9, 4, 3, 0, 5, 5},
                    new[] {0, 0, 3, 6, 9, 5}
                },
                new[]
                {
                    new[] {1, 9},
                    new[] {1, 6, 4},
                    new[] {9, 4, 3, 0, 5, 5},
                    new[] {0, 0, 3, 6, 9, 5}
                }};
            }
        }

        [Test, TestCaseSource("OrderByMinElementDescData")]
        public void OrderByMinElementDesc_ArraySortedByMinElementInRowDescending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSort.OrderByMinElementDesc(sourceArray);
            IStructuralEquatable resultArray = testData[1];

            Assert.AreEqual(resultArray.Equals(sourceArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        #endregion
    }
}
