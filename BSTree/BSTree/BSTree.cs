using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {

        public BSTree()
        {
            root = null;
        }
        public BSTree(Node<T> node)
        {
            root = node;
        }
        

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
                return;
            }
            if (item.CompareTo(tree.Data) != 0)
            {
                if (item.CompareTo(tree.Data) < 0)
                    insertItem(item, ref tree.Left);
                else if (item.CompareTo(tree.Data) > 0)
                    insertItem(item, ref tree.Right);
            }   
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        public int Height(Node<T> node)
        {
            if (node == null) return 0;

            int leftHeight = 0;
            int rightHeight = 0;

            if (node.Left != null) leftHeight = Height(node.Left);
            if (node.Right != null) rightHeight = Height(node.Right);

            return leftHeight > rightHeight ? ++leftHeight : ++rightHeight;
        }

        public int Count()
        {
            if (root != null)
            {
                int count = 1;
                return Count(root, ref count);
            }
            return 0;
        }
        public int Count(Node<T> node, ref int count)
        {
            
            if (node.Left != null)
            {
                count += 1;
                Count(node.Left, ref count);

            }
            if (node.Right != null)
            {
                count += 1;
                Count(node.Right, ref count);

            }
            return (count);
        }

        public Boolean Contain(Node<T> node)
        {
            if (node.Data != null)
                return true;
            else
                return false;
        }

       

        public Node<T> LeastItem(Node<T> node)
        {
            if (node == null)
                return null;

            if (node.Left == null)
                return node;

            else return LeastItem(node.Left);
        }


        public void RemoveItem(T item, ref Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            else if (item.CompareTo(node.Data) < 0)
                RemoveItem(item, ref node.Left);

            else if (item.CompareTo(node.Data) > 0)
                RemoveItem(item, ref node.Right);

            else if (item.Equals(node.Data))
            {
                if (node.Left == null && node.Right == null)
                {
                    node = null;
                    return; 
                }
                else if (node.Left == null)
                {
                    //Node<T> temp = node;
                    node = node.Right;
                    //temp = null;
                }
                else if (node.Right == null)
                {
                    //Node<T> temp = node;
                    node = node.Left;
                    //temp = null;
                }
                else
                {
                    Node<T> min = LeastItem(node.Right);
                    node.Data = min.Data;
                    RemoveItem(min.Data, ref node.Right);
                }
                

            }
            return;
        }

        public void RemoveItem(T item)
        {
            
            RemoveItem(item, ref this.root);
            
        }

        
    }



}
