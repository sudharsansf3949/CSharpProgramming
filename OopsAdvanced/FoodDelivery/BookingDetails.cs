using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId=3000;
        public string BookingId { get; set; }
        public string CustomerId { get; set; }
        public int TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }

        public BookingDetails(string customerId,int totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            CustomerId=customerId;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus=bookingStatus;
        }

        public BookingDetails(string Data)
        {
            string [] value=Data.Split(',');
            s_bookingId=int.Parse(value[0].Remove(0,3));
            BookingId=value[0];
            CustomerId=value[1];
            TotalPrice=int.Parse(value[2]);
            DateOfBooking=DateTime.Parse(value[3]);
            BookingStatus=Enum.Parse<BookingStatus>(value[4]);
        }


        public void ShowBookDetails()
        {
            System.Console.WriteLine("Your Booking Id is   : "+BookingId);
            System.Console.WriteLine("Your Customer Id is  : "+CustomerId);
            System.Console.WriteLine("Your Total Bill vlue is: "+TotalPrice);
            System.Console.WriteLine("Your Date of Booking is: "+DateOfBooking);
            System.Console.WriteLine("Your Booking status is: "+BookingStatus);
        }
    }
}