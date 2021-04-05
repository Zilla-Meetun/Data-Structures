using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libray
{
    class Book : IComparable
    {
        private string title;
        private Person author;
        private Person authorAge;

        public Book(string title)
        {
            this.title = title;
        }

        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }

        public Person Author
        {
            get { return author; }
            set { author = value; }
        }

        public Person AuthorAge
        {
            get { return authorAge; }
            set { author = value; }
        }

        public string GetSumary()
        {
            return title + " written by " + author.Name+ " at age "+ author.Age;
        }
        


        public int CompareTo(Object obj) //implementation of CompareTo
        {                   // for IComparable
            Book other = (Book)obj;
            return Author.CompareTo(other.Author); //uses Name for comparison        
        }

       

             
        
    }
}
