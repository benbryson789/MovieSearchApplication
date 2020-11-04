using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Movie150.Models;

namespace Movie150.Controllers
{
    public class MovieController : Controller
    {
        public static List<Movie> Movies = new List<Movie>
        {
            new Movie(1, "Cool Runnings", "Comedy", 1998),
            new Movie(2, "I dont' know", "Romance", 2005),
            new Movie(3, "Some kind of robot", "Sci-Fi", 2030),
            new Movie(4, "Dracula", "Horror", 1976),
        };

        public Movie Movie { get; set; }

        public IActionResult MovieResult(Movie movie)
        {
            Movie = movie;
            return View(Movie);
        }

        public IActionResult Search()
        {
            return View(Movies);
        }

        public IActionResult SearchResultGenre(string genre)
        {
            List<Movie> moviesByGenre = new List<Movie>();

            if (!string.IsNullOrEmpty(genre))
            {
                foreach (Movie movie in Movies)
                {
                    if (movie.Genre.ToLower().Contains(genre.ToLower()))
                    {
                        moviesByGenre.Add(movie);
                    }
                }
            }


            return View("SearchResult", moviesByGenre);
        }

        public IActionResult SearchResultTitle(string title)
        {
            List<Movie> moviesByTitle = new List<Movie>();

            if (!string.IsNullOrEmpty(title))
            {
                foreach (Movie movie in Movies)
                {
                    if (movie.Title.ToLower().Contains(title.ToLower()))
                    {
                        moviesByTitle.Add(movie);
                    }
                }
            }

            return View("SearchResult", moviesByTitle);
        }
    }
}
