using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicket
{
    public class ScreeningDetails
    {
        public string MovieId { get; set; }
        public string TheatreId { get; set; }
        public int NoofSeats { get; set; }
        public double TicketPrice { get; set; }


        public ScreeningDetails(string movieId,string theareId,double ticketPrice,int noofSeats)
        {
            MovieId=movieId;
            TheatreId=theareId;
            NoofSeats=noofSeats;
            TicketPrice=ticketPrice;
        }

        public ScreeningDetails(string data)
        {
            string [] value=data.Split(',');
            MovieId=value[0];
            TheatreId=value[1];
            NoofSeats=int.Parse(value[2]);
            TicketPrice=double.Parse(value[3]);
        }
    }
}