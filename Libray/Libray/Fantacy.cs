using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libray
{
    class Fantacy : Book
    {
        public Fantacy(string title) : base(title)
        {
            base.Author = new Person("Another person", 25);
        }
    }
    
}
