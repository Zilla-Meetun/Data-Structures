using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class LinkList
    {
        private Link list = null; //default value – empty list

       

        public void AddItem(int item) //add item to front of list
        {
            list = new Link(item, list);
        }

        public void RemoveItem(int item)
        {
            Link current = list;
            Link previous = null;

            while (current != null)
            {
                if (current.Data == item)
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

            public bool IsPresentItem(int item)
        {
            Link temp = list;
            while(temp!= null)
            {
                if(item == temp.Data)
                {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        public string DisplayItems() //write items to string and return
        {
            Link temp = list;
            string buffer = "";
            while (temp != null) // move one link and add head to the buffer
            {
                buffer += temp.Data + "|";

                temp = temp.Next;
            }
            return buffer;
        }

        public int NumberOfItems() // returns number of items in list
        {
            Link temp = list;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }
    }


}
