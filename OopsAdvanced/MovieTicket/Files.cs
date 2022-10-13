using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicket
{
    public static class Files
    {
        public static  void Create()
        {
            if(!Directory.Exists("MovieTicket"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("MovieTicket");
            }
            if(!File.Exists("MovieTicket/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("MovieTicket/BookingDetails.csv");
            }
            if(!File.Exists("MovieTicket/MovieDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("MovieTicket/MovieDetails.csv");
            }
            if(!File.Exists("MovieTicket/ScreeningDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("MovieTicket/ScreeningDetails.csv");
            }
            if(!File.Exists("MovieTicket/TheatreDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("MovieTicket/TheatreDetails.csv");
            }
            if(!File.Exists("MovieTicket/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create("MovieTicket/UserDetails.csv");
            }

        }

        public static void ReadFile()
        {
            string [] users=File.ReadAllLines("MovieTicket/UserDetails.csv");
            foreach(string data in users )
            {
                UserDetails user=new UserDetails(data);
                Operations.userList.Add(user);
            }

            string [] booking=File.ReadAllLines("MovieTicket/BookingDetails.csv");
            foreach(string data in booking)
            {
                BookingDetails bookings=new BookingDetails(data);
                Operations.bookingList.Add(bookings);
            }

            string[] movie=File.ReadAllLines("MovieTicket/MovieDetails.csv");
            foreach(string data in movie)
            {
                MovieDetails movies=new MovieDetails(data);
                Operations.movieList.Add(movies);
            }

            string [] screen=File.ReadAllLines("MovieTicket/ScreeningDetails.csv");
            foreach(string data in screen)
            {
                ScreeningDetails screening=new ScreeningDetails(data);
                Operations.screeningList.Add(screening);
            }

            string [] theatre=File.ReadAllLines("MovieTicket/TheatreDetails.csv");
            foreach(string data in theatre)
            {
                TheatreDetails theatres=new TheatreDetails(data);
                Operations.theatreList.Add(theatres);
            }   
        }

        public static void WriteFile()
        {
            string [] user=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                user[i]=Operations.userList[i].UserId+","+Operations.userList[i].Name+","+Operations.userList[i].Age+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("MovieTicket/UserDetails.csv",user);

            string [] booking=new string[Operations.bookingList.Count];
            for(int i=0;i<Operations.bookingList.Count;i++)
            {
                booking[i]=Operations.bookingList[i].BookingId+","+Operations.bookingList[i].UserId+","+Operations.bookingList[i].MovieId+","+Operations.bookingList[i].TheatreId+","+Operations.bookingList[i].SeatCount+","+Operations.bookingList[i].TotalAmount+","+Operations.bookingList[i].BookingStaus;
            }
            File.WriteAllLines("MovieTicket/BookingDetails.csv",booking);

            string [] movie=new string[Operations.movieList.Count];
            for(int i=0;i<Operations.movieList.Count;i++)
            {
                movie[i]=Operations.movieList[i].MovieId+","+Operations.movieList[i].MovieName+","+Operations.movieList[i].Language;
            }
            File.WriteAllLines("MovieTicket/MovieDetails.csv",movie);

            string[] screening =new string[Operations.screeningList.Count];
            for(int i=0;i<Operations.screeningList.Count;i++)
            {
                screening[i]=Operations.screeningList[i].MovieId+","+Operations.screeningList[i].TheatreId+","+Operations.screeningList[i].TicketPrice+","+Operations.screeningList[i].NoofSeats;
            }
            File.WriteAllLines("MovieTicket/ScreeningDetails.csv",screening);

            string [] theatre=new string[Operations.theatreList.Count];
            for(int i=0;i<Operations.theatreList.Count;i++)
            {
                theatre[i]=Operations.theatreList[i].TheatreId+","+Operations.theatreList[i].TheatreName+","+Operations.theatreList[i].TheatreLocation;
            }
            File.WriteAllLines("MovieTicket/TheatreDetails.csv",theatre);
        }
    }
}