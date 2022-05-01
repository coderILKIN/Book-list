using System;
using System.Collections.Generic;
using System.Text;

namespace Books
{
    internal class Book
    {

        private static int counter=10;

        public int count { get; set; }

        public string Name { get; set; }

        public string AuthorName { get; set; }

        public int PageCount { get; set; }

        public string Code { get; set; }


        public Book(string name,string authorname,int pagecount,string code)
        {
            count = ++counter;
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            Code = code.Substring(0, 2).ToUpper() + counter;
        }
    }
}
