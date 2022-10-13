using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBooks
{
    public static class Operations
    {
        static UserDetails currentUser=null;
        static List<UserDetails> userList= new List<UserDetails>();
        static List<BookDetails> bookList=new List<BookDetails>();
        static List<UserDetails> UserList=new List<UserDetails>();
        static List<BorrowDetails>borrowList=new List<BorrowDetails>();

        public static void DefaultData()
        {
            UserDetails user1=new("SF3001","Ravichandran",Gender.Male,Department.EEE,998388338,"ravi@gmail.com");
            UserDetails user2=new("SF3002","Priyadharshini",Gender.Female,Department.CSE,994113992,"priya@mail");
            userList.Add(user1);
            userList.Add(user2);

            BookDetails book1=new("BID101","C#","Author1",3);
            BookDetails book2=new("BID102","HTML","Author2",5);
            BookDetails book3=new("BID103","CSS","Author1",3);
            BookDetails book4=new("BID104","JS","Author1",3);
            BookDetails book5=new("BID105","TS","Author2",2);
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);
            bookList.Add(book5);


            BorrowDetails borrow1=new("LB301","BID101","SF3001",new DateTime(2022/04/10),Status.Issue);
            BorrowDetails borrow2=new("LB302","BID103","SF3001",new DateTime(2022/04/12),Status.Return);
            BorrowDetails borrow3=new("LB303","BID104","SF3001",new DateTime(2022/04/15),Status.Issue);
            BorrowDetails borrow4=new("LB304","BID102","SF3002",new DateTime(2022/04/11),Status.Return);
            BorrowDetails borrow5=new("LB305","BID105","SF3002",new DateTime(2022/04/15),Status.Issue);
            borrowList.Add(borrow1);
            borrowList.Add(borrow2);
            borrowList.Add(borrow3);
            borrowList.Add(borrow4);
            borrowList.Add(borrow5);

        }


        public static void ManinMenu()
        {
            DefaultData();
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select the option....");
                System.Console.WriteLine("1.User Registration 2.User Login 3.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Welcome to User Registration");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Welcome to User Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        choice="no";
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Enter a valid option");
                        break;
                    }
                }

            }while(choice=="yes");
        }



        public static void UserRegistration()
        {
            System.Console.WriteLine("Enter your Name: ");
            string userName=Console.ReadLine();
            System.Console.WriteLine("Enter your Gender male,female,transgender ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your Department CSE or ECE or EEE");
            Department department=Enum.Parse<Department>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your Mobile Number: ");
            long mobileNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Mail Id: ");
            string mailId=Console.ReadLine();

            UserDetails user=new("",userName,gender,department,mobileNumber,mailId);
            userList.Add(user);

            System.Console.WriteLine("Successfully Registered your register number is : "+user.RegistrationId);
            
        }


        public static void Login()
        {
            System.Console.WriteLine("Enter your Registration id");
            string id=Console.ReadLine().ToUpper();
            foreach(UserDetails user in userList)
            {
                if(id==user.RegistrationId)
                {
                    System.Console.WriteLine("Login Successfull");
                    currentUser=user;
                    SubMenu();
                }
               
            }
        }


        public static void SubMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("1.Borrow Book 2.Show Borrowed History 3.Return Books 4.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Borrow Book");
                        BorrowBook();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Show History");
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Return Book");
                        ReturnBook();
                        break;
                    }
                    case 4:
                    {
                        choice="No";
                        break;
                    }
                }
            }while(choice=="yes");
        }

        

        public static void BorrowBook()
        {
            System.Console.WriteLine("The available books are....");
            foreach(BookDetails book in bookList)
            {
                System.Console.WriteLine(" ");
                System.Console.WriteLine("The Book id is    : "+book.BookId);
                System.Console.WriteLine("The Book name is  : "+book.BookName);
                System.Console.WriteLine("The Author name is: "+book.AuthorName);
                System.Console.WriteLine("The Book count is : "+book.BookCount);
                System.Console.WriteLine("");
            }

            System.Console.WriteLine("Enter book ID which you want to take: ");
            string bookId=Console.ReadLine().ToUpper();

            foreach(BookDetails book in bookList)
            {
                if(bookId==book.BookId )
                {
                    if(book.BookCount>=1)
                    {
                        foreach(BorrowDetails borrow in borrowList)
                        {
                            if(borrow.RegistrationID!=currentUser.RegistrationId)
                            {
                                borrow.Status=Status.Issue;
                                book.BookCount--;
                                BorrowDetails borrow1=new("",book.BookId,currentUser.RegistrationId,DateTime.Now,borrow.Status);
                                borrowList.Add(borrow1);
                                if(currentUser.RegistrationId==borrow.RegistrationID)
                                {
                                    System.Console.WriteLine("Book Borrowed Sccuessfully and your borrow id is: "+borrow.BorrowID);
                                    break;
                                }
                            }
                        }
                    }
                }
            
            }
            
        }


        public static void ReturnBook()
        {
            foreach(BorrowDetails borrow in borrowList)
            {
                if(currentUser.RegistrationId==borrow.RegistrationID)
                {
                    DateTime date= borrow.BorrowedDate.AddDays(15);
                    System.Console.WriteLine("The Return Date of the book is "+date);
                    if(borrow.BorrowedDate<=date)
                    {
                        foreach(BookDetails book in bookList)
                        {
                            if(book.BookId==borrow.BookId)
                            {
                                borrow.Status=Status.Return;
                            }
                        }
                    }
                    else
                    {
                        DateTime currentDate=DateTime.Now;
                        //TimeSpan fineDay= (TimeSpan)currentDate-date;
                        System.Console.WriteLine("You have to pay the penalty");
                    }

                }
            }
        }


        public static void ShowHistory()
        {
            foreach(BorrowDetails borrow in borrowList)
            {
                if(currentUser.RegistrationId==borrow.RegistrationID)
                {
                    System.Console.WriteLine("The Borrow Id is                 : "+borrow.BorrowID);
                    System.Console.WriteLine("The Book Id you borrowed is      : "+borrow.BookId);
                    System.Console.WriteLine("The Borrowed date of the book is : "+borrow.BorrowedDate);
                }
            }
        }
    }
}