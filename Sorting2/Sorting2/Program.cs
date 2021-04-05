using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst1 = { 3, 6, 2, 9, 1 };
            char[] lst2 = { 'n', 'z', 'f', 'q' };
            string buf = null;
// Quicksort QS = new Quicksort();


            foreach(int s in lst1)
            {
                buf += String.Format("{0}", s);
            }
            Console.WriteLine(buf);
            buf = null;
            foreach (char s in lst2)
            {
                buf += String.Format("{0}", s);
            }
            Console.WriteLine(buf);
            quickSortDD2(lst1, 0, lst1.Length-1);
            quickSortDD2(lst2, 0, lst2.Length - 1);

            buf = null;
            foreach (int s in lst1)
            {
                buf += String.Format("{0}", s);
            }
            Console.WriteLine(buf);
            buf = null;
            foreach (char s in lst2)
            {
                buf += String.Format("{0}", s);
            }
            Console.WriteLine(buf);
            Console.ReadKey();
        }

        static void quickSortDD2<T>(T[] items, int left, int right) where T : IComparable<T>
        {
            int i, j;
            i = left; j = right;
            T pivot = items[left];

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

        static void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
