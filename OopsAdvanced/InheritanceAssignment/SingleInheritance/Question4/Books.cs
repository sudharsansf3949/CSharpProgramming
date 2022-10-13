using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class Books
    {
        public string BookId { get; set; }
        public string BookName { get; set; }
        public string  AuthorName { get; set; }
        public int Price { get; set; }



        public Books(string bookId,string bookName,string authorName,int price)
        {
            BookId=bookId;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }


        public void showDetails()
        {
            System.Console.WriteLine("The book name is      : "+BookName);
            System.Console.WriteLine("This book author is   : "+AuthorName);
            System.Console.WriteLine("The price of the book is: "+Price);
        }
    }
}