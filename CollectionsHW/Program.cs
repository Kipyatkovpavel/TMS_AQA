// See https://aka.ms/new-console-template for more information
using CollectionsHW;
using System.Collections;
using System.ComponentModel;

public class Program
{
    public static void Main()
    {
        Library library = new Library();
        library.AddBook("Война и мир", "Лев Толстой", 1865);
        library.AddBook("Преступление и наказание", "Федор Достоевский", 1866);
        library.AddBook("Тарас Бульба", "Николай Гоголь", 1842);

        Console.WriteLine("Выберете интересующую вас функцию программы:");
        Console.WriteLine("Если вы хотите добавить книгу в библиотеку, нажмите \"1\" ");
        Console.WriteLine("Если вы хотите увидеть все книги в нашей библиотеке, нажмите \"2\" ");
        Console.WriteLine("Если вы хотите найти книгу по автору, нажмите \"3\" ");
        Console.WriteLine("Если вы хотите убрать книгу из библиотеке, нажмите \"4\" ");
        Console.WriteLine("Если вы хотите выйти, нажмите \"5\" ");

        while (true)
        {
            var userchoise = Console.ReadLine();
            switch (userchoise)
            {
                case "1":
                    Console.WriteLine("Введите название книги: ");
                    string bookname = Console.ReadLine();
                    Console.WriteLine("Введите автора книги: ");
                    string author = Console.ReadLine();
                    Console.WriteLine("Введите год издания книги: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    library.AddBook(bookname,author, year);
                    break;
                case "2":
                    library.ShowAllBooks();
                    break;
                case "3":
                    Console.WriteLine("Введите автора, интересующей/-их вас книги/-книг:");
                    string authorToFind = Console.ReadLine();
                    library.FindBook(authorToFind);
                    break;
                case "4":
                    Console.WriteLine("Введите название книги, которую хотите удалить: ");
                    string booknameDelete = Console.ReadLine();
                    library.DeleteBook(booknameDelete);
                    continue;
                case "5":
                    Environment.Exit(0); break;
                default: Console.WriteLine("Неправильный ввод.Возможно вы выбрали цифру не из списка.");
                    break;
            }
        }
    }
}






        