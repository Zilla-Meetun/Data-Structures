using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libray
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[5];  //declare an array of Book

            books[0] = new Book("Moby Dick");
            books[0].Author = new Person("Herman Melville", 20);
            books[1] = new Horror("The Creeping");
            books[1].Author = new Person("Someone" , 20);
            books[2] = new Horror("More Than This");
            books[2].Author = new Person("Patric Ness", 30);
            books[3] = new Adventure("book 1");
            books[4] = new Fantacy("book 2");


            for (int i = 0; i < 5; i++)
                //Console.WriteLine("{0} written by {1} at age {2}", books[i].Title, books[i].Author.Name, books[i].Author.Age);
                Console.WriteLine(books[i].GetSumary());
            Console.ReadKey();
        }

    }
}
