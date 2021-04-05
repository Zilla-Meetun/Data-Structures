using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{
    class Node<T> where T : IComparable
    {
        private T data;
        public Node<T> Left, Right;
        private int balanceFactor = 0;

        public Node(T item)
        {
            data = item;
            Left = null;
            Right = null;
        }
        public T Data
        {
            set { data = value; }
            get { return data; }
        }
        public int BalanceFactor
        {
            set { balanceFactor = value; }
            get { return balanceFactor; }
        }

        public void PrintPretty(string indent, bool last)
        {

            Console.Write(indent);
            if (last)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "| ";
            }
            Console.WriteLine(Data);

            var children = new List<Node<T>>();
            if (this.Left != null)
                children.Add(this.Left);
            if (this.Right != null)
                children.Add(this.Right);

            for (int i = 0; i < children.Count; i++)
                children[i].PrintPretty(indent, i == children.Count - 1);

        }

    }
}


