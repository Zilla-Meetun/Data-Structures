using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{
    class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public AVLTree()
        {
            root = null;
        }
        public AVLTree(Node<T> node)
        {
            root = node;
        }

        public new void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
                
            }
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
            
            tree.BalanceFactor = Height(tree.Left) - Height(tree.Right);

            if (tree.BalanceFactor <= -2)
                rotateLeft(ref tree);
            if (tree.BalanceFactor >= 2)
                rotateRight(ref tree);

        }

        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)
                rotateRight(ref tree.Right);
            Node<T> oldRoot = tree;
            Node<T> newRoot = oldRoot.Right;
            tree = newRoot;
            oldRoot.Right = newRoot.Left;
            newRoot.Left = oldRoot;
            

            

        }

        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)
                rotateLeft(ref tree.Left);
            Node<T> oldRoot = tree;
            Node<T> newRoot = oldRoot.Left;
            tree = newRoot;
            oldRoot.Left = newRoot.Right;
            newRoot.Right = oldRoot;
        }

    }

}
