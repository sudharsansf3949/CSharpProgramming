using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicket
{
    public enum BookingStatus{Defaut,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId=7000;
        public string  BookingId { get; set; }
        public string UserId { get; set; }
        public string MovieId { get; set; }
        public string  TheatreId { get; set; }
        public int SeatCount { get; set; }
        public double TotalAmount { get; set; }
        public BookingStatus BookingStaus { get; set; }

        public BookingDetails(string userId,string movieId,string theareId,int seatCount,double totalAmount,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            UserId=userId;
            MovieId=movieId;
            TheatreId=theareId;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStaus=bookingStatus;
        }

        public BookingDetails(string data)
        {
            string [] value=data.Split(',');
            s_bookingId=int.Parse(value[0].Remove(0,3));
            BookingId=value[0];
            UserId=value[1];
            MovieId=value[2];
            TheatreId=value[3];
            SeatCount=int.Parse(value[4]);
            TotalAmount=double.Parse(value[5]);
            BookingStaus=Enum.Parse<BookingStatus>(value[6]);
        }
        
    }
}