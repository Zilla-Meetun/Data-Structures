using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libray
{
    class Adventure : Book
    {
        public Adventure(string title) : base(title)
        {
            base.Author = new Person("Someone", 25);
        }
    }
}
