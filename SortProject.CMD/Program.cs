using SortProject.BL;
using System;

namespace SortProject.CMD
{
    class Program
    {
        static void Main()
        {
            int[] array = { 9, 5, 6, 3, 2, 1, 5, 7, 8, 9, 5, 2 };

            //BubbleSort<int> bubbleSort = new BubbleSort<int>(array);
            //array = bubbleSort.Sort();
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //CoctailSort<int> coctailSort = new CoctailSort<int>(array);
            //array = coctailSort.Sort();
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //InsertSort<int> insertSort = new InsertSort<int>(array);
            //array = insertSort.Sort();
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //ShellSort<int> shellSort = new ShellSort<int>(array);
            //array = shellSort.Sort();
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //SelectionSort<int> selectionSort = new SelectionSort<int>(array);
            //array = selectionSort.Sort();
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //GnomeSort<int> gnomeSort = new GnomeSort<int>(array);
            //array = gnomeSort.Sort();
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}


            //RadixSort radixSort = new RadixSort(array);
            //array = radixSort.Sort();
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            MergeSort<int> mergeSort = new MergeSort<int>(array);
            array = mergeSort.Sort();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
