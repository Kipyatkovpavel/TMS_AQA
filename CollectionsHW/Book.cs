using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHW
{
    public class Book
    {
        public string bookname;
        public string author;
        public int year;

        public Book(string bookname, string author, int year)
        {
            this.bookname = bookname;
            this.author = author;
            this.year = year;
        }

        public string ShowBook()
        {
            return $"Название книги: {bookname}, Автор: {author}, Год издания: {year}";
        }
    }


}
