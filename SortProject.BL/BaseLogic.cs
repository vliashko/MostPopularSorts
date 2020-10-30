using System;

namespace SortProject.BL
{
    public class BaseLogic<T> where T : IComparable<T>
    {
        protected readonly T[] array;
        public BaseLogic(T[] array)
        {
            this.array = array;
        }
        public virtual T[] Sort()
        {
            return array;
        }

        protected void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
