using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList testList = new LinkList();

            testList.AddItem(4);
            testList.AddItem(2);
            testList.AddItem(4);
            testList.AddItem(5);
            testList.AddItem(4);
            testList.AddItem(1);
            testList.AddItem(20);
            testList.AddItem(4);
            testList.AddItem(7);
            testList.AddItem(24);
            testList.AddItem(101);


            Console.WriteLine(testList.DisplayItems());

            Console.WriteLine(testList.NumberOfItems());

            Console.WriteLine(testList.IsPresentItem(3));
            Console.WriteLine(testList.IsPresentItem(2));

            testList.RemoveItem(4);

            Console.WriteLine(testList.DisplayItems());

            Console.WriteLine();
       
            Console.ReadKey();
        }
    }
}
