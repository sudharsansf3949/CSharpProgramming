using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicket
{
    public class MovieDetails
    {
        public string MovieId { get; set; }
        public string MovieName { get; set; }
        public string Language { get; set; }

        public MovieDetails(string movieId,string movieName,string language)
        {
            MovieId=movieId;
            MovieName=movieName;
            Language=language;
        }

        public MovieDetails(string data)
        {
            string [] value=data.Split(',');
            MovieId=value[0];
            MovieName=value[1];
            Language=value[2];
        }
    }
}