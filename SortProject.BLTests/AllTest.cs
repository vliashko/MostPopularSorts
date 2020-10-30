using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortProject.BL;
using System;

namespace SortProject.BLTests
{
    [TestClass()]
    public class AllTest
    {
        const int counter = 20000;
        Random rnd = new Random();
        int[] array = new int[counter];
        int[] expected = new int[counter];

        [TestInitialize]
        public void Init()
        {
            for (int i = 0; i < counter; i++)
            {
                array[i] = rnd.Next(0, 1000);
            }

            Array.Copy(array, expected, array.Length);
            Array.Sort(expected);
        }


        [TestMethod()]
        public void BaseSortTest()
        {
            BaseLogic<int> sort = new BaseLogic<int>(array);

            int[] result = CreateResultArray();
            Array.Sort(result);

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod()]
        public void BubbleSortTest()
        {
            int[] result = CreateResultArray();

            BubbleSort<int> sort = new BubbleSort<int>(result);

            result = sort.Sort();

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void CocktailSortTest()
        {
            int[] result = CreateResultArray();

            CoctailSort<int> sort = new CoctailSort<int>(result);

            result = sort.Sort();

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void InsertSortTest()
        {
            int[] result = CreateResultArray();

            InsertSort<int> sort = new InsertSort<int>(result);

            result = sort.Sort();

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void ShellSortTest()
        {
            int[] result = CreateResultArray();

            ShellSort<int> sort = new ShellSort<int>(result);

            result = sort.Sort();

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            int[] result = CreateResultArray();

            SelectionSort<int> sort = new SelectionSort<int>(result);

            result = sort.Sort();

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void GnomeSortTest()
        {
            int[] result = CreateResultArray();

            GnomeSort<int> sort = new GnomeSort<int>(result);

            result = sort.Sort();

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void RadixSortTest()
        {
            int[] result = CreateResultArray();

            RadixSort sort = new RadixSort(result);

            result = sort.Sort();

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            int[] result = CreateResultArray();

            MergeSort<int> sort = new MergeSort<int>(result);

            result = sort.Sort();

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest()
        {
            int[] result = CreateResultArray();

            QuickSort<int> sort = new QuickSort<int>(result);

            result = sort.Sort();

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        private int[] CreateResultArray()
        {
            int[] result = new int[counter];
            Array.Copy(array, result, array.Length);
            return result;
        }
    }
}
