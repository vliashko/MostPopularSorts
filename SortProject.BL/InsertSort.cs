using System;

namespace SortProject.BL
{
    /// <summary>
    /// O(nLogn) - лучший, O(n^2) - худший.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class InsertSort<T> : BaseLogic<T> where T : IComparable<T>
    {
        public InsertSort(T[] array) : base(array)
        {
        }

        public override T[] Sort()
        {
            for (int i = 1; i < array.Length; i++)
            {
                T temp = array[i];
                int j = i;

                while (j > 0 && temp.CompareTo(array[j - 1]) == -1)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = temp;
            }
            return array;
        }
    }
}
