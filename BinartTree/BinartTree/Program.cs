using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinartTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> tree1 = new Node<int>(6);
            tree1.Left = new Node<int>(2);
            tree1.Left.Right = new Node<int>(5);
            

            BinTree<int> tree2 = new BinTree<int>(tree1);

            string buf = null;
            tree2.InOrder(ref buf);
            Console.WriteLine(buf);

            buf = null;
            tree2.PreOrder(ref buf);
            Console.WriteLine(buf);

            buf = null;
            tree2.PostOrder(ref buf);
            Console.WriteLine(buf);


            Console.ReadKey();
        }
    }
}
