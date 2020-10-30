using System;
using System.Linq;

namespace SortProject.BL
{
    /// <summary>
    /// O(nLogn) - стабильно
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MergeSort<T> : BaseLogic<T> where T : IComparable<T>
    {
        public MergeSort(T[] array) : base(array)
        {
        }
        public override T[] Sort()
        {
            return MakeSort(array, 0, array.Length - 1);
        }
        private T[] MakeSort(T[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                int middleIndex = (lowIndex + highIndex) / 2;
                MakeSort(array, lowIndex, middleIndex);
                MakeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }
        private void Merge(T[] array, int lowIndex, int middleIndex, int highIndex)
        {
            int left = lowIndex;
            int right = middleIndex + 1;
            T[] tempArray = new T[highIndex - lowIndex + 1];
            int index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left].CompareTo(array[right]) == -1)
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (int i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (int i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (int i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }
    }
}
