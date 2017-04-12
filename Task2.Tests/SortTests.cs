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
    public class SortTests
    {
        #region OrderBySumAsc Tests

        public static IEnumerable<int[][][]> OrderBySumAscData
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

        [Test, TestCaseSource(nameof(OrderBySumAscData))]
        public void OrderBySumAsc_ArraySortedByElementsSumInRowAscending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSort.Sort(new ComparerBySumAsc(), sourceArray);
            IStructuralEquatable resultArray = testData[1];

            Assert.AreEqual(resultArray.Equals(sourceArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [Test, TestCaseSource(nameof(OrderBySumAscData))]
        public void OrderBySumAscConverse_ArraySortedByElementsSumInRowAscending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSortConverse.Sort(new ComparerBySumAsc(), sourceArray);
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

        [Test, TestCaseSource(nameof(OrderBySumDescData))]
        public void OrderBySumDesc_ArraySortedByElementsSumInRowDescending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSort.Sort(new CompareBySumDesc(), sourceArray);
            IStructuralEquatable resultArray = testData[1];

            Assert.AreEqual(resultArray.Equals(sourceArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [Test, TestCaseSource(nameof(OrderBySumDescData))]
        public void OrderBySumDescConverse_ArraySortedByElementsSumInRowDescending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSortConverse.Sort(new CompareBySumDesc(), sourceArray);
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

        [Test, TestCaseSource(nameof(OrderByMaxElementAscData))]
        public void OrderByMaxElementAsc_ArraySortedByMaxElementInRowAscending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSort.Sort(new CompareByMaxElementAsc(), sourceArray);
            IStructuralEquatable resultArray = testData[1];

            Assert.AreEqual(resultArray.Equals(sourceArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [Test, TestCaseSource(nameof(OrderByMaxElementAscData))]
        public void OrderByMaxElementAscConverse_ArraySortedByMaxElementInRowAscending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSortConverse.Sort(new CompareByMaxElementAsc(), sourceArray);
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

        [Test, TestCaseSource(nameof(OrderByMaxElementDescData))]
        public void OrderByMaxElementDesc_ArraySortedByMaxElementInRowDescending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSort.Sort(new CompareByMaxElementDesc(), sourceArray);
            IStructuralEquatable resultArray = testData[1];

            Assert.AreEqual(resultArray.Equals(sourceArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [Test, TestCaseSource(nameof(OrderByMaxElementDescData))]
        public void OrderByMaxElementDescConverse_ArraySortedByMaxElementInRowDescending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSortConverse.Sort(new CompareByMaxElementDesc(), sourceArray);
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

        [Test, TestCaseSource(nameof(OrderByMinElementAscData))]
        public void OrderByMinElementAsc_ArraySortedByMinElementInRowAscending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSort.Sort(new CompareByMinElementAsc(), sourceArray);
            IStructuralEquatable resultArray = testData[1];

            Assert.AreEqual(resultArray.Equals(sourceArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [Test, TestCaseSource(nameof(OrderByMinElementAscData))]
        public void OrderByMinElementAscConverse_ArraySortedByMinElementInRowAscending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSortConverse.Sort(new CompareByMinElementAsc(), sourceArray);
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

        [Test, TestCaseSource(nameof(OrderByMinElementDescData))]
        public void OrderByMinElementDesc_ArraySortedByMinElementInRowDescending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSort.Sort(new CompareByMinElementDesc(), sourceArray);
            IStructuralEquatable resultArray = testData[1];

            Assert.AreEqual(resultArray.Equals(sourceArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        [Test, TestCaseSource(nameof(OrderByMinElementDescData))]
        public void OrderByMinElementDescConverse_ArraySortedByMinElementInRowDescending(int[][][] testData)
        {
            int[][] sourceArray = testData[0];
            BubbleSortConverse.Sort(new CompareByMinElementDesc(), sourceArray);
            IStructuralEquatable resultArray = testData[1];

            Assert.AreEqual(resultArray.Equals(sourceArray, StructuralComparisons.StructuralEqualityComparer), true);
        }

        #endregion
    }
}
