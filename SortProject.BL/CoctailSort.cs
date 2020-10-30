using System;

namespace SortProject.BL
{
    /// <summary>
    /// O(n) - лучший, O(n^2) - худший.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CoctailSort<T> : BaseLogic<T> where T : IComparable<T>
    {
        public CoctailSort(T[] array) : base(array)
        {
        }

        public override T[] Sort()
        {
            int left = 0;
            int right = array.Length - 1;

            while(left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) == 1)
                        Swap(ref array[i], ref array[i + 1]);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    if (array[i].CompareTo(array[i - 1]) == -1)
                        Swap(ref array[i], ref array[i - 1]);
                }
                left++;
            }
            return array;
        }
    }
}
