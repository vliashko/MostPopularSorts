using System;
using System.Collections;

namespace SortProject.BL
{
    /// <summary>
    /// O(n), работает с цифрами.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RadixSort
    {
        private readonly int[] array;
        public RadixSort(int[] array)
        {
            this.array = array;
        }
        public int[] Sort()
        {
            int range = 10;
            int length = 3;

            ArrayList[] lists = new ArrayList[range];
            for (int i = 0; i < range; i++)
                lists[i] = new ArrayList();

            for (int step = 0; step < length; step++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int temp = array[i] % (int)Math.Pow(range, step + 1) / (int)Math.Pow(range, step);
                    lists[temp].Add(array[i]);
                }
                int k = 0;
                for (int i = 0; i < range; i++)
                {
                    for (int j = 0; j < lists[i].Count; j++)
                    {
                        array[k++] = (int)lists[i][j];
                    }
                }
                for (int i = 0; i < range; i++)
                    lists[i].Clear();
            }

            return array;
        }
    }
}
