using System;
using System.Collections.Generic;
using System.Text;

namespace Books
{
    internal class Library
    {

        public List<Book> Books = new List<Book>();
        public List<Book> FindAllBookByName(string value)
        {
            return Books.FindAll(x => x.Name.Contains(value));
        }
        public void RemoveAllBooksByName(string value)
        {
            Books.RemoveAll(x => x.Name.Contains(value));
        }
        public List<Book> SearchBook(string value)
        {
            return Books.FindAll(book => book.Name.Contains(value) || book.AuthorName.Contains(value) || book.PageCount.ToString().Contains(value));
        }
        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            return Books.FindAll(x => x.PageCount >= min && x.PageCount <= max);
        }
        public void RemoveBookByCode(string value)
        {
            Book wantedBook = Books.Find(x => x.Code == value);
            if (wantedBook != null)
            {
                Books.Remove(wantedBook);
            }

        }


    }
}
