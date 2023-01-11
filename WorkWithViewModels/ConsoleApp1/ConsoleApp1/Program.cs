// the user will search the book in the database, passing its credentials (for now only the title)

using ConsoleApp1;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        var book_db = new BookDAO();
        var bookList = book_db.Read();

        


        Console.WriteLine("titolo: ");
        var title = Console.ReadLine();

        var query = bookList.Where( b => b.Title == title ).Select(e => e.BookId).Take(1).ToList();

        var finalBook = new BookViewModel(query[0], title);

        Console.WriteLine($"il libro {finalBook.Title} ha id {finalBook.Id}");




    }
}