using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBooks
{
    public class BookDetails
    {
        private static int s_bookId=100;
        public string BookId { get; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int BookCount { get; set; }


        public BookDetails(string bookId, string bookName,string authorName,int bookCount)
        {
            s_bookId++;
            BookId="BID"+s_bookId;
            BookName=bookName;
            AuthorName=authorName;
            BookCount=bookCount;

        }
    }
}