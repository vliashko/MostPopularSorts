using System;

namespace SortProject.BL
{
    /// <summary>
    /// O(n^2) - лучший, O(n^2) - худший.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SelectionSort<T> : BaseLogic<T> where T : IComparable<T>
    {
        public SelectionSort(T[] array) : base(array)
        {
        }

        public override T[] Sort()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) == -1)
                        minIndex = j;
                }

                if(i != minIndex)
                    Swap(ref array[i], ref array[minIndex]);
            }

            return array;
        }
    }
}
