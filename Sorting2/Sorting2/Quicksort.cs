using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Sorting2
{
    class Quicksort
    {

        public void quickSortDD2<T>(T[] items, int left, int right) where T : IComparable
        {
            int i, j;
            i = left; j = right;
            IComparable pivot = items[left];

            while (i <= j)
            {
                for (; (items[i].CompareTo(pivot) < 0) && (i.CompareTo(right) < 0); i++) ;
                for (; (pivot.CompareTo(items[j]) < 0) && (j.CompareTo(left) > 0); j--) ;

                if (i <= j)
                    swap(ref items[i++], ref items[j--]);
            }

            if (left < j) quickSortDD2<T>(items, left, j);
            if (i < right) quickSortDD2<T>(items, i, right);
        }

        void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }


    }
}
*/