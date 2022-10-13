using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBooks
{
    public enum Status{Default,Issue,Return}
    public class BorrowDetails
    {
        private static int s_borrowId=300;
        public string BorrowID { get;  }
        public string BookId { get; set; }
        public string RegistrationID { get; set; }
        public DateTime BorrowedDate { get; set; }
        public Status Status { get; set; }


        public BorrowDetails(string borrowId, string bookId,string registrationId,DateTime borrowedDate,Status status)
        {
            s_borrowId++;
            BorrowID="LB"+s_borrowId;
            BookId=bookId;
            RegistrationID=registrationId;
            BorrowedDate=borrowedDate;
            Status=status;

        }
    }
}