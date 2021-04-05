using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab6_library_
{
    class Book
    {
        private String isbn;
        private string title;
        private Boolean onloan = false;
        private int size;
        



        public Book(string isbn, string title)
        {
            this.isbn = isbn;
            this.title = title;
        }

        public string ISBN
        {
            get { return isbn; }
            set { this.isbn = value; }
        }
        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }
        public Boolean Onloan
        {
            get { return onloan; }
            set { this.onloan = value; }
        }


    }
}
