using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //            string buffer="";
            //            BSTree<int> myTree = new BSTree<int>();
            //            myTree.InsertItem(9);
            //            myTree.InsertItem(4);
            //            myTree.InsertItem(10);
            //            myTree.InsertItem(11);
            //            myTree.InsertItem(5);
            //            myTree.PreOrder(ref buffer);
            //            Console.WriteLine(buffer);
            //            
            //           Console.WriteLine(myTree.height(myTree));
            //
            //            Console.WriteLine(myTree.Count());
            //
            //            myTree.RemoveItem(9);
            //            buffer = null;
            //            myTree.PreOrder(ref buffer);
            //            Console.WriteLine(buffer);
            //
            AVLTree<int> avl = new AVLTree<int>();
            avl.InsertItem(4);
            avl.InsertItem(2);
            avl.InsertItem(6);
            avl.InsertItem(5);

            
            string buffer = null;
            avl.PreOrder(ref buffer);
            Console.WriteLine(buffer);
            buffer = null;
            avl.InOrder(ref buffer);
            Console.WriteLine(buffer);
            buffer = null;
            avl.PostOrder(ref buffer);
            Console.WriteLine(buffer);

            buffer = null;

            Console.WriteLine();

            //avl.Print();
            Console.ReadKey();



        }



    }
}
