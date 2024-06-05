using Section01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section01 {
    internal class Program {
        static void Main(string[] args) {

            var books = Books.GetBooks().OrderByDescending(b => b.Price).ToArray();

            books.ForEach(b => Console.WriteLine(b.Title + ":" + b.Price));

            /*var average = Books.GetBooks().Average(x=>x.Pages);
            Console.WriteLine(average);

            var page = Books.GetBooks().Max(x=> x.Pages);
            Console.WriteLine(page);

            var bookTitle = Books.GetBooks().FirstOrDefault(b => b.Pages == page);
            Console.WriteLine(bookTitle.Title);*/
        }
    }
}
