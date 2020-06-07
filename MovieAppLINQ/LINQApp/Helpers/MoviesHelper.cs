using LINQApp.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LINQApp.Helpers
{
    public class MoviesHelper
    {
        public static List<Movie> GetAllActionMovies()
        {
            return new List<Movie>()
            {
                new Movie(){ Title = "The Mountain II", Year = 2016, Rating = 8.9f, Duration = 135 },
                new Movie(){ Title = "Seven Samurai", Year = 1954, Rating = 8.6f, Duration = 207 },
                new Movie(){ Title = "Big Hero 6", Year = 2014, Rating = 7.8f, Duration = 102 },
                new Movie(){ Title = "The Man from Nowhere", Year = 2010, Rating = 7.8f, Duration = 119 },
                new Movie(){ Title = "Gladiator", Year = 2000, Rating = 8.5f, Duration = 155 },
                new Movie(){ Title = "Avengers: Endgame", Year = 2009, Rating = 8.4f, Duration = 181 },
                new Movie(){ Title = "Kung Fu Hustle", Year = 2004, Rating = 7.7f, Duration = 99 },
                new Movie(){ Title = "Iron Man", Year = 2008, Rating = 7.9f, Duration = 126 },
                new Movie(){ Title = "Big Hero 7", Year = 2014, Rating = 7.8f, Duration = 102 },
                new Movie(){ Title = "The Dark Knight", Year = 2008, Rating = 9.0f, Duration = 152 },
                new Movie(){ Title = "13 Assassins", Year = 2010, Rating = 7.6f, Duration = 141 },
                new Movie(){ Title = "Grindhouse", Year = 2007, Rating = 7.5f, Duration = 191 },

                new Movie(){Title = "Interstellar", Year = 2014, Rating = 8.6f, Duration = 169},
                new Movie(){Title = "The Matrix", Year = 1999, Rating = 8.7f, Duration = 136},
                new Movie(){Title = "The Shawshank Redemption", Year = 1994, Rating = 9.3f, Duration = 142},
                new Movie(){Title = "Saving Private Ryan", Year = 1998, Rating = 8.6f, Duration = 169},
                new Movie(){Title = "Terminator 2: Judgment Day", Rating = 8.5f, Year = 1991,  Duration = 137},
                new Movie(){Title = "The Prestige", Year = 2006, Rating = 8.5f, Duration = 130},
                new Movie(){Title = "Casino Royale", Year = 2006, Rating = 8.0f, Duration = 144},
                new Movie(){Title = "Forrest Gump", Year = 1994, Rating = 8.8f, Duration = 142},
                new Movie(){Title = "The Godfather", Year = 1972, Rating = 9.2f, Duration = 175},
                new Movie(){Title = "A Beautiful Mind", Year = 2001, Rating = 8.2f, Duration = 135},

            };
        }
        public static List<Movie> MyMovies(List<Movie> ListOfMovies)
        {
            return ListOfMovies.Where(m => m.Duration >= 100).ToList();
        }
    }
}