using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId=3000;
        public string BookingId { get; set; }
        public string CustomerID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }


        public BookingDetails(string customerId,double totalPrice,DateTime dateofBooking,BookingStatus bookingStatus)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            CustomerID=customerId;
            TotalPrice=totalPrice;
            DateOfBooking=dateofBooking;
            BookingStatus=bookingStatus;
        }

        public BookingDetails(string Data)
        {
            string [] value=Data.Split(',');
            s_bookingId=int.Parse(value[0].Remove(0,3));
            BookingId=value[0];
            CustomerID=value[1];
            TotalPrice=int.Parse(value[2]);
            DateOfBooking=DateTime.Parse(value[3]);
            BookingStatus=Enum.Parse<BookingStatus>(value[4]);
        }
        public void ShowBookingDetails()
        {
            System.Console.WriteLine("The Booking Id is: "+BookingId);
            System.Console.WriteLine("The Customer Id is: "+CustomerID);
            System.Console.WriteLine("The Price of the order: "+TotalPrice);
            System.Console.WriteLine("The date of the booking: "+DateOfBooking);
            System.Console.WriteLine("Your Booking Status is: "+BookingStatus);
            System.Console.WriteLine(" ");
        }

    }
}