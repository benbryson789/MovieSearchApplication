using System;

namespace Movie150.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public string Genre { get; set; }

        public int Year { get; set; }

        public string Actors { get; set; }

        public string Directors { get; set; }

        public Movie()
        {
                
        }

        public Movie(int id, string title, string genre, int year)
        {
            ID = id;
            Title = title;
            Genre = genre;
            Year = year;
        }
    }
}
