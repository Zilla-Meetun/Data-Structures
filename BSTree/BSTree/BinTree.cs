using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{
    class BinTree<T> where T : IComparable
    {
        protected Node<T> root;
        public BinTree()  //creates an empty tree
        {
            root = null;
        }
        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public void InOrder(ref string buffer)
        {
            InOrder(root, ref buffer);

        }

        public void InOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                InOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + '|';
                InOrder(tree.Right, ref buffer);

            }



        }

        public void PreOrder(ref string buffer)
        {
            PreOrder(root, ref buffer);

        }

        public void PreOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString() + '|';
                PreOrder(tree.Left, ref buffer);
                PreOrder(tree.Right, ref buffer);


            }
        }


        public void PostOrder(ref string buffer)
        {
            PostOrder(root, ref buffer);

        }

        public void PostOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                PostOrder(tree.Left, ref buffer);
                PostOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + '|';

            }
        }

        public void Print()
        {
            root.PrintPretty("", true);
        }

    }
}
