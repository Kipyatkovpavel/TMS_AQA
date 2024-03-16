using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHW
{
    public class Library
    {
        public ArrayList library = new ArrayList();

        public void AddBook(string bookname, string author, int year)
        {
            Book book = new Book(bookname, author, year);
            library.Add(book);
            Console.WriteLine("Вы добавили свою книгу");
        }
        public void ShowAllBooks()
        {
            if (library.Count == 0)
            {
                Console.WriteLine("На данный момент библиотека только открылась, но вы можете принести свои книги");
            }
            else
            {
                foreach (Book book in library)
                {
                    Console.WriteLine(book.ShowBook());
                }
            }
        }
        public void FindBook(string author)
        {
            int i = 0;
            foreach (Book book in library)
            {

                if (book.author.ToLower().Equals(author.ToLower()))
                {
                    Console.WriteLine(book.ShowBook());
                    i++;
                }
            }
            if (i == 0)
            {
                Console.WriteLine("В библиотеке нет книг от этого автора");
            }
        }
        public void DeleteBook(string bookname)
        {
            int j = 0;
            foreach (Book book in library)
            {
                if (book.bookname.ToLower().Equals(bookname.ToLower()))
                {

                    j++;
                    //library.Remove(book); // (Через название книги)
                    var index = library.IndexOf(book);
                    Console.WriteLine($"Поиск индекса вашего элемента': {index}");
                    library.RemoveAt(index); // по названию определяем индекс и удаляем по индексу, удаляется первое совпадение по индексу.
                    Console.WriteLine($"Книга успешно удалена: {book.ShowBook()}");
                    return;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("В библиотеке нет указанной вами книги");
            }
        }
    }
}



