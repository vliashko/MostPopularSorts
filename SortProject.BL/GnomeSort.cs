using System;

namespace SortProject.BL
{
    /// <summary>
    /// O(n^2) - лучший, O(n^2) - худший.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GnomeSort<T> : BaseLogic<T> where T : IComparable<T>
    {
        public GnomeSort(T[] array) : base(array)
        {
        }

        public override T[] Sort()
        {
            int i = 1;
            int nextIndex = i + 1;

            while (i < array.Length)
            {
                if (array[i].CompareTo(array[i - 1]) == 1)
                {
                    i = nextIndex;
                    nextIndex++;
                }
                else
                {
                    Swap(ref array[i - 1], ref array[i]);
                    i--;
                    if (i == 0)
                    {
                        i = nextIndex;
                        nextIndex++;
                    }
                }
            }
            return array;
        }
    }
}
