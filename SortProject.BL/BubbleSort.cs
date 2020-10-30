using System;

namespace SortProject.BL
{
    /// <summary>
    /// O(n) - лучший, O(n^2) - худший.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BubbleSort<T> : BaseLogic<T> where T : IComparable<T>
    {
        public BubbleSort(T[] array) : base(array)
        {
        }
        public override T[] Sort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) == 1)
                        Swap(ref array[j], ref array[j + 1]);
                }
            }
            return array;
        }
    }
}
