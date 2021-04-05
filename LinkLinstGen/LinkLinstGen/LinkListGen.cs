using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkLinstGen 
{

    class LinkListGen<T> where T : IComparable
    {
        private LinkGen<T> list = null;


        public LinkGen<T> List
        {
            set { this.list = value; }
            get { return this.list; }
        }


        public LinkListGen()
        {   
        }

        public void AddItem(T item)
        {
            list = new LinkGen<T>(item, list);
        }

        public void AppendItem(T item)
        {
            
            if( list.Data == null)
            {
                list.Data = item;
            }
            else
            {
                LinkGen<T> temp;
                for (temp = list; temp.Next != null; temp = temp.Next) ;
                temp.Next = new LinkGen<T>(item, null);
            }
            
        }

       public void Concat(LinkListGen<T> items)
        {

            LinkGen<T> temp = items.List;
            while (temp != null)
            {
                this.AppendItem(temp.Data);
                temp = temp.Next;
            }
        }

        public void Copy(LinkListGen<T> items)
        {
            list  = null;
            LinkGen<T> temp = items.List;
            while (temp != null)
            {
                this.AddItem(temp.Data);
                temp = temp.Next;
            }

        }

        public void Sort()
        {
            LinkGen<T> temp = list;
            LinkListGen<T> newList = new LinkListGen<T>();
            while (temp != null)
            {
                newList.InsertInOrder(temp.Data);
                temp = temp.Next;
            }
            list = newList.List;
        }

        public void InsertInOrder(T item)
        {
            LinkGen<T> temp = list;
            LinkGen<T> prev = null;
            if (list == null)
            {
                list.Data = item;
            }
            if (item.CompareTo(temp.Data) < 0)
            {
                this.AddItem(item);
                
            }
            else
            {
                while (item.CompareTo(temp.Data) > 0))

                prev = temp;
                temp = temp.Next;
            }
           
        }

        /*
        public void InsertInOrder(T item)
        {
            LinkGen<T> temp = list;
            LinkGen<T> prev = null;
            if (list == null || item.CompareTo(list.Data) < 0)
            {
                this.AddItem(item);
            }
            else
            {
                do
                {
                    if (prev != null && item.CompareTo(prev.Data) >= 0 && item.CompareTo(temp.Data) <= 0)
                    {
                        prev.Next = new LinkGen<T>(item, temp);

                    }
                    prev = temp;
                    temp = temp.Next;

                }
                while (temp != null && item.CompareTo(temp.Data) <= 0);

            }
            if (prev == null || item.CompareTo(prev.Data) > 0)
            {

                this.AppendItem(item);
            }
       
            
            

           
         }
        */



        public string DisplayList()
        {
            LinkGen<T> temp = list;
            string buffer = "";
            while (temp != null)
            {
                buffer += temp.Data + "|";

                temp = temp.Next;
            }
            return buffer;
        }
        public int NumberOfItems()
        {
            LinkGen<T> temp = list;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

        public bool IsPresentItem(T item)
        {
            LinkGen<T> temp = list;
            while (temp != null)
            {
                if (temp.Data.CompareTo(item) == 0)
                {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }


        public void RemoveItem(T item)
        {
            LinkGen<T> current = list;
            LinkGen<T> previous = null;

            while (current != null)
            {
                if (current.Data.CompareTo(item) == 0)
                {
                    if (previous != null)
                    {

                        previous.Next = current.Next;
                        current = current.Next;

                    }


                    else
                    {
                        previous = current;
                        current = current.Next;
                        list = current;
                    }
                }
                else
                {
                    previous = current;
                    current = current.Next;
                }

            }
        }

     }

}
