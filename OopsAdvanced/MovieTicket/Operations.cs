using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicket
{
    public delegate void  EventManager();
    public static class Operations
    {
        //public static void event EventManger=null;
        //Creating a list for user to store the values
        public static List<UserDetails> userList           =new List<UserDetails>();
        public  static List<BookingDetails> bookingList    =new List<BookingDetails>();
        public  static List<TheatreDetails> theatreList    =new List<TheatreDetails>();
        public  static List<MovieDetails> movieList        =new List<MovieDetails>();
        public  static List<ScreeningDetails>screeningList =new List<ScreeningDetails>();
        static UserDetails currentUser=null;
        //Initialize the Main Menu
        public static void MainMenu()
        {
            //DefaultData();
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select the Option \n1.User Registration \n2.Login \n3.Exit\n");
                int option =int.Parse(Console.ReadLine());
                switch(option)
                {
                    case (1):
                    {
                        System.Console.WriteLine("Welcome to User Registration ");
                        UserRegistration();
                        break;
                    }
                    case (2):
                    {
                        System.Console.WriteLine("Welcome to User Login");
                        Login();
                        break;
                    }
                    case(3):
                    {
                        choice="no";
                        System.Console.WriteLine("Exiting from main menu");
                        break;
                    }
                }
            }while(choice =="yes");
            
        }

        public static void UserRegistration()
        {
            System.Console.WriteLine("Enter Your Name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Age: ");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Phone Number: ");
            long phoneNumber=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your Wallet Balance: ");
            double walletBalane=double.Parse(Console.ReadLine());
            UserDetails user =new UserDetails (name,age,phoneNumber,walletBalane);
            userList.Add(user);
            System.Console.WriteLine("User Registration is Successfull");
            System.Console.WriteLine("Your User Id is: "+user.UserId);

        }

        public static void DefaultData()
        {

            //user data
            UserDetails user1 =new UserDetails("Ravichandran",30,8599488003,1000);
            UserDetails user2=new UserDetails("Baskaran",30,9857747327,2000);
            userList.Add(user1);
            userList.Add(user2);

            //booking data
            BookingDetails booking1=new BookingDetails("UID1001","MID501","TID301",1,200,BookingStatus.Booked);
            BookingDetails booking2=new BookingDetails("UID1001","MID504","TID302",1,400,BookingStatus.Booked);
            BookingDetails booking3=new BookingDetails("UID1002","MID505","TID302",1,300,BookingStatus.Booked);
            bookingList.Add(booking1);
            bookingList.Add(booking2);
            bookingList.Add(booking3);
            
            //  Screening data
            ScreeningDetails showing1=new ScreeningDetails("MID501","TID301",200,5);
            ScreeningDetails showing2=new ScreeningDetails("MID502","TID301",300,2);
            ScreeningDetails showing3=new ScreeningDetails("MID506","TID301",50,1);
            ScreeningDetails showing4=new ScreeningDetails("MID501","TID302",400,11);
            ScreeningDetails showing5=new ScreeningDetails("MID502","TID302",300,20);
            ScreeningDetails showing6=new ScreeningDetails("MID504","TID302",500,2);
            ScreeningDetails showing7=new ScreeningDetails("MID505","TID303",100,11);
            ScreeningDetails showing8=new ScreeningDetails("MID502","TID303",200,20);
            ScreeningDetails showing9=new ScreeningDetails("MID504","TID303",350,2);
            screeningList.Add(showing1);
            screeningList.Add(showing2);
            screeningList.Add(showing3);
            screeningList.Add(showing4);
            screeningList.Add(showing5);
            screeningList.Add(showing6);
            screeningList.Add(showing7);
            screeningList.Add(showing8);
            screeningList.Add(showing9);


            //Movie data

            MovieDetails movie1=new MovieDetails("MID501","Bagubali","Telugu");
            MovieDetails movie2=new MovieDetails("MID503","Cobra","Tamil");
            MovieDetails movie3=new MovieDetails("MID504","Vikram","Hindi(Dubbed)");
            MovieDetails movie4=new MovieDetails("MID505","Vikram","Tamil");
            MovieDetails movie5=new MovieDetails("MID506","Beast","English");
            MovieDetails movie6=new MovieDetails("MID502","PonniyinSelvan","Tamil");
            movieList.Add(movie1);
            movieList.Add(movie3);
            movieList.Add(movie2);
            movieList.Add(movie4);
            movieList.Add(movie5);
            movieList.Add(movie6);

            //theatre details
            TheatreDetails theatre1=new TheatreDetails("Inox","AnnaNagar");
            TheatreDetails theatre2=new TheatreDetails("EgaTheatre","Chetpet");
            TheatreDetails theatre3=new TheatreDetails("Kamala" ,"Vadapalani");
            theatreList.Add(theatre1);
            theatreList.Add(theatre2);
            theatreList.Add(theatre3);

        }

        public static void Login()
        {
            System.Console.WriteLine("Enter your User Id: ");
            string id=Console.ReadLine().ToUpper();
            foreach(UserDetails user in userList)
            {
                if(id==user.UserId)
                {
                    System.Console.WriteLine("Login Successful");
                    currentUser=user;
                    SubMenu();
                }
               /* else
                {
                    System.Console.WriteLine("Invalid user id");
                }
                */
            }
        }

        public static void SubMenu()
        {
            string choice="yes";
            do
            {
                System.Console.WriteLine("Select Option \na.Ticket Booking\nb.Ticket Cancellation\nc.Booking History\nd.Wallet Recharge\ne.Exit");
                char option=char.Parse(Console.ReadLine().ToLower());
                switch(option)
                {
                    case('a'):
                    {
                        System.Console.WriteLine("Ticket Booking");
                        TicketBooking();
                        break;
                    }
                    case('b'):
                    {
                        System.Console.WriteLine("Ticket Cancellation");
                        TicketCancel();
                        break;
                    }
                    case('c'):
                    {
                        System.Console.WriteLine("Booking History");
                         BookingHistory();
                        break;
                    }
                    case('d'):
                    {
                        System.Console.WriteLine("Wallet Recharge");
                        WalletRecharge();
                        break;
                    }
                    case('e'):
                    {
                        choice="no";
                        System.Console.WriteLine("Exiting from Sub Menu");
                        break;
                    }
                }
            }while(choice=="yes");
        }

        public static void TicketBooking()
        {

            System.Console.WriteLine("------------- For The Fututre Reference---------- ");
            foreach(MovieDetails movie in movieList)
            {
                System.Console.WriteLine(movie.MovieId+"  - "+movie.MovieName+"("+movie.Language+")");
            }
            //show the list of theatres
            foreach(TheatreDetails theatre in theatreList)
            {
                System.Console.WriteLine("The Theatre Id is:      "+theatre.TheatreId);
                System.Console.WriteLine("The Threatre Name is:   "+theatre.TheatreName);
                System.Console.WriteLine("The Theatre Location is: "+theatre.TheatreLocation);
                System.Console.WriteLine("");
            }
           
            //selct theatre by theatre id
            System.Console.WriteLine("Select the Theatre and Enter the Theatre ID:");
            string id=Console.ReadLine().ToUpper();

            foreach(TheatreDetails theatre in theatreList)
            {
                if(id==theatre.TheatreId)
                {
                    foreach(ScreeningDetails screening in screeningList)
                    {

                        if(screening.TheatreId==theatre.TheatreId && screening.TheatreId==id)
                        {
                            System.Console.WriteLine(" ");
                            System.Console.WriteLine("The Movie ID is: "+screening.MovieId);
                            System.Console.WriteLine("The seat availability is :"+screening.NoofSeats);
                            System.Console.WriteLine("The ticket price is: "+screening.TicketPrice);
                            System.Console.WriteLine("");
                        }   
                    }   
                }
            }

            System.Console.WriteLine("Select the movie Id in the above list: ");
            string userMovieId=Console.ReadLine().ToUpper();
            
            foreach(MovieDetails movie in movieList)
            {
                foreach(TheatreDetails theatre in theatreList)
                {
                    if(userMovieId==movie.MovieId && theatre.TheatreId==id)
                    {
                        System.Console.WriteLine("The movie name is: "+movie.MovieName);
                        System.Console.WriteLine("The Movie Language is: "+movie.Language);
                    }
                }  
            }

            System.Console.WriteLine("Enter how many tickets you want: ");
            int userCount=int.Parse(Console.ReadLine());
            double amount=0;
            double totalAmount=0;
            foreach(TheatreDetails theatre in theatreList)
            {
                if(id==theatre.TheatreId)
                {
                    foreach(ScreeningDetails screening in screeningList)
                    {
                        if(screening.TheatreId==theatre.TheatreId && screening.TheatreId==id)
                        {
                            if(userCount<=screening.NoofSeats)
                            {
                                amount=userCount*screening.TicketPrice;
                                totalAmount=amount+(amount*0.18);
                                if(totalAmount<=currentUser.WalletBalance)
                                {
                                    currentUser.WalletBalance-=totalAmount;
                                    screening.NoofSeats-=userCount;
                                    BookingDetails booking=new(currentUser.UserId,screening.MovieId,id,userCount,totalAmount,BookingStatus.Booked);
                                    bookingList.Add(booking);
                                    System.Console.WriteLine("Booking Successfull");
                                    System.Console.WriteLine("Your booking id is: "+booking.BookingId);
                                    break;
                                }
                                else
                                {
                                    System.Console.WriteLine("Insufficient Balance Recharge your Wallet");
                                }
                            }
                            else
                            {
                                System.Console.WriteLine("Seat not Availbale");
                            }
                        }
                    }
                }
            }
        } 

        public static  void TicketCancel()
        {
            BookingHistory();
            System.Console.WriteLine("Enter the booking Id you want to cancel: ");
            string id=Console.ReadLine().ToUpper();
            foreach(BookingDetails booking in bookingList)
            {
                 
                foreach(ScreeningDetails screening in screeningList)
                {
                    if(booking.BookingStaus==BookingStatus.Booked)
                    {
                        if(booking.TheatreId==screening.TheatreId)
                        {
                            screening.NoofSeats+=booking.SeatCount;
                            currentUser.WalletBalance+=booking.TotalAmount;
                            System.Console.WriteLine("Order Cancelled Successfully");
                        }
                    }
                }
            }
        }

        public static void BookingHistory()
        {
            foreach(BookingDetails booking in bookingList)
            {
                if(currentUser.UserId==booking.UserId)
                {
                    System.Console.WriteLine("Your Booking Id is: "+booking.BookingId);
                    System.Console.WriteLine("Your Movie Id is: "+booking.MovieId);
                    System.Console.WriteLine("Your Theatre Id is: "+booking.TheatreId);
                    System.Console.WriteLine("Your Seat count is: "+booking.SeatCount);
                    System.Console.WriteLine("Your Total Amount is: "+booking.TotalAmount);
                    System.Console.WriteLine("Your Booking Status is: "+booking.BookingStaus);
                }
            }
        }

        public static void WalletRecharge()
        {
            System.Console.WriteLine("Enter amount to Reacharge: ");
            double money=double.Parse(Console.ReadLine());
            double amount=currentUser.RechargeWallet(money);
            currentUser.WalletBalance=amount;
            System.Console.WriteLine("The updated balance is: "+currentUser.WalletBalance);
        }

    }
}