using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Book
    {
        public string tittle;
        public string author;
        public int pages;

        //Constructor
        public Book(string atitile,string aAuthour,int aPage)
        {
            tittle = atitile;
            author = aAuthour;
            pages = aPage;

        }

    }
}
