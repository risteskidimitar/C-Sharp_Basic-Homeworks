using LINQApp.Entities;
using LINQApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQApp
{
    class Program
    {
        static void Main(string[] args)
        {

        
            #region HOMEWORK LINQ

            List<Movie> allmovies = MoviesHelper.GetAllActionMovies();

            List<Movie> movies = MoviesHelper.MyMovies(allmovies);

            // 1 Find all movies that their titles starts with "L"

            var StartLLambda = movies.Where(m => m.Title.StartsWith("L")).ToList();

            StartLLambda.ForEach(m => Console.WriteLine(m.Title));
            if (StartLLambda.Count == 0)
            {
                Console.WriteLine("We don't have film starting with L");
            }

            var StartLQuery = (from movie in movies where movie.Title.StartsWith("L") select movie).ToList();

            // 2 Find the NUMBER of movies that have rating higher than 7.5

            var numLambda = movies.Where(m => m.Rating > 7.5f).ToList().Count;

            var numQuery = (from movie in movies where movie.Rating > 7.5f select movie).ToList().Count;
            Console.WriteLine("Number of movies with rating higher than 7.5 is " + numQuery);

            // 3 Find all movies TITLES with year of production before 2005

            var before2005Lambda = movies.Where(m => m.Year < 2005).Select(m => m.Title).ToList();
            before2005Lambda.ForEach(m => Console.WriteLine(m));

            var before2005Query = (from m in movies where m.Year < 2005 select m.Title).ToList();
            //before2005Query.ForEach(m => Console.WriteLine(m));

            // 4 Find all movies TITLES and RATING that have rating higher then 8.0

            var tilesAndRatingLambda = movies.Where(m => m.Rating > 8.0f)
                                               .Select(m => new { Naslov = m.Title, Rejting = m.Rating }).ToList();

            tilesAndRatingLambda.ForEach(m => Console.WriteLine(m));

            var tilesAndRatingQuery = (from movie in movies where movie.Rating > 8.0f select movie).
                                      Select(m => new { Naslov = m.Title, Rejting = m.Rating }).ToList();

            tilesAndRatingQuery.ForEach(m => Console.WriteLine(m));

            // 5 Find first 5 movies that have duration time longer then 2 hours

            var first5longer120Lambda = movies.Where(m => m.Duration > 120).Take(5).ToList();
            //first5longer120Lambda.ForEach(m => Console.WriteLine(m.Title));

            var first5longer120Query = (from movie in movies where movie.Duration > 120 select movie).Take(5).ToList();
            first5longer120Query.ForEach(m => Console.WriteLine(m.Title));

            // 6 Find last 3 movies TITLES and DURATION that have duration less then 2 hours

            var last3less120Lambda = movies.Where(m => m.Duration < 120)
                                            .TakeLast(3).Select(m => new { m.Title, m.Duration }).ToList();


            //last3less120Lambda.ForEach(m => Console.WriteLine(m));

            var last3less120Query = (from movie in movies where movie.Duration < 120 select movie)
                                      .Select(m => new { m.Title, m.Duration }).TakeLast(3).ToList();

            last3less120Query.ForEach(m => Console.WriteLine(m));


            // 7 Find all movies TITLES and RATING and order them by DURATION (DESC) - no condition needed

            var descDurationLambda = movies.OrderByDescending(d => d.Duration).Select(m => new { m.Title, m.Rating }).ToList();

            descDurationLambda.ForEach(m => Console.WriteLine(m));


            var descDurationQuery = (from movie in movies select movie).OrderByDescending(d => d.Duration)
                                .Select(m => new { m.Title, m.Rating }).ToList();


            // 8 Find all movies with TITLES that don't start with A and TITLES include more than 7 characters

            var char7notstartA = movies.Where(m => m.Title.Length > 7 && !m.Title.StartsWith('A')).ToList();


            var char7notstartAQuery = (from movie in movies
                                       where movie.Title.Length > 7 && !movie.Title.StartsWith('A')
                                       select movie).ToList();

            char7notstartAQuery.ForEach(m => Console.WriteLine(m.Title));


            // 9 Find all movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour and 50min

            var ratingsLambda = movies.Where(m => m.Rating > 7.2f && m.Duration > 110).Select(m => m.Rating).ToList();

            var ratingsQuery = (from movie in movies
                                where movie.Rating > 7.2f && movie.Duration > 110
                                select movie.Rating).ToList();

            

            ratingsQuery.ForEach(m => Console.WriteLine(m));

            // Find all movies TITLES and RATINGS that have TITLES with less than 10 characters, DURATION
            //longer than 2 hours, RATING higher then 6.7 and order them by TITLE(ASC)

            var lastCondition = movies.Where(m => m.Title.Length < 10 && m.Duration > 120 && m.Rating > 6.7f)
                               .OrderBy(t => t.Title).Select(m => new { Title = m.Title, Rating = m.Rating }).ToList();


            var lastConditionQuery = (from m in movies
                                      where m.Title.Length < 10 && m.Duration > 120 && m.Rating > 6.7f 
                                      select m)
                                     .OrderBy(t => t.Title)
                                     .Select(m => new { Title = m.Title, Rating = m.Rating }).ToList();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            lastCondition.ForEach(m => Console.WriteLine(m));


            #endregion

            Console.ReadLine();
        }
    }
}