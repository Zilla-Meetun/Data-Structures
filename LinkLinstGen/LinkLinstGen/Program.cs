using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkLinstGen
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkListGen<int> testList = new LinkListGen<int>();
            LinkListGen<int> testList2 = new LinkListGen<int>();
            LinkListGen<int> newList = new LinkListGen<int>();



            newList.AddItem(10);
            newList.AppendItem(19);
            newList.AddItem(8);

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

            testList2.AddItem(4);
            testList2.AddItem(2);
            
            Console.WriteLine(testList.DisplayList());

            Console.WriteLine(testList.NumberOfItems());

            Console.WriteLine(testList.IsPresentItem(3));
            Console.WriteLine(testList.IsPresentItem(2));

            testList.RemoveItem(4);
            testList.AppendItem(7);
            Console.WriteLine(testList.DisplayList());
            Console.WriteLine(newList.DisplayList());

            testList.Concat(newList);

            Console.WriteLine(testList.DisplayList());

            testList.Copy(newList);
            Console.WriteLine(testList.DisplayList());


            testList2.InsertInOrder(1);
            testList2.InsertInOrder(3);
            testList2.InsertInOrder(5);
    
            Console.WriteLine(testList2.DisplayList());

            newList.Sort();
            Console.WriteLine(newList.DisplayList());

            Console.ReadKey();
        }





    }
}
