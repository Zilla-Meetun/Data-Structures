using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libray
{
    class Person : IComparable
    {
        private int age;
        private string name;

        //constructor with one argument        
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //property for name            
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int CompareTo(Object obj) //implementation of CompareTo
        {                   // for IComparable

            Person other = (Person)obj;
            return Name.CompareTo(other.Name); //uses Name for comparison 
             

        }

     

    }


}
