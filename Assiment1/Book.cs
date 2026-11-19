using System;
using System.Collections.Generic;
using System.Text;

namespace Assiment1
{
    internal class Book
    {
       public string Title;
        public int Pages;
        public override string ToString()
        {
            return $"Pages : {Pages},Title :{Title}";
        }
    }
}
