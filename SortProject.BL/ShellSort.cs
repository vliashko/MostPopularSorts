using System;

namespace SortProject.BL
{
    /// <summary>
    /// O(nLogn) - лучший, O(n^2) - худший.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ShellSort<T> : BaseLogic<T> where T : IComparable<T>
    {
        public ShellSort(T[] array) : base(array)
        {
        }

        public override T[] Sort()
        {
            int step = array.Length / 2;

            while(step > 0)
            {
                for (int i = step; i < array.Length; i++)
                {
                    int j = i;
                    while (j >= step && array[j - step].CompareTo(array[j]) == 1)
                    {
                        Swap(ref array[j - step], ref array[j]);
                        j -= step;
                    }
                }
                step /= 2;
            }
            return array;
        }
    }
}
