using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicket
{
    public class TheatreDetails
    {
        private static int s_theatreId=300;
        public string TheatreId { get; set; }
        public string TheatreName { get; set; }
        public string TheatreLocation { get; set; }

        public TheatreDetails(string theatreName,string theatreLocation)
        {
            s_theatreId++;
            TheatreId="TID"+s_theatreId;
            TheatreName=theatreName;
            TheatreLocation=theatreLocation;
        }

        public TheatreDetails(string data)
        {
            string [] value=data.Split(',');
            s_theatreId=int.Parse(value[0].Remove(0,3));
            TheatreId=value[0];
            TheatreName=value[1];
            TheatreLocation=value[2];
        }
    }
}