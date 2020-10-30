using System;

namespace SortProject.BL
{
    /// <summary>
    /// O(nLogn) - лучший, O(n^2) - худший.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QuickSort<T> : BaseLogic<T> where T : IComparable<T>
    {
        public QuickSort(T[] array) : base(array)
        {
        }

        public override T[] Sort()
        {
            return MakeSort(array, 0, array.Length - 1);
        }
        private T[] MakeSort(T[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            MakeSort(array, minIndex, pivotIndex - 1);
            MakeSort(array, pivotIndex + 1, maxIndex);

            return array;
        }
        private int Partition(T[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i].CompareTo(array[maxIndex]) == -1)
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
    }
}
