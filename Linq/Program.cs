using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Linq
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            var enumerableList = books.ToList();
            
            // LINQ Query Operators
            var cheaperBooks = from b in enumerableList where b.Price < 10 orderby b.Title select b.Title;
            foreach (var selectedBook in cheaperBooks)
            {
                Console.WriteLine(selectedBook);
            }
            
            Console.WriteLine("-----------");
            
            // LINQ Extension Methods
            var selectedBooks = enumerableList.Where(b => b.Price < 10).OrderBy(b => b.Title).Select(b => b.Title);
            foreach (var selectedBook in selectedBooks)
            {
                Console.WriteLine(selectedBook);
            }
            
            // Get a single object    (will throw exception if more than one element is found)
            var book = enumerableList.SingleOrDefault(b => b.Price <= 4);    // if finded, return true, else return false
            Console.WriteLine("Find a book with its price lower than or equal to 4: {0}",book != null?book.Title:"null");
            
            // Get the first object
            var expensiveBook = enumerableList.FirstOrDefault(b => b.Price > 7);
            // Similar: enumerableList.LastOrDefault
            Console.WriteLine("Find the first book with its price higher than 7: {0}",expensiveBook?.Title);
            
            
        }
    }
}