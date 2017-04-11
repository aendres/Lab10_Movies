using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Movies
{
    class MainClass
    {
        static List<Movie> movieList = new List<Movie>();
        

        static void Main(string[] args)
        {
            movieList.Add(new Movie("Beauty and the Beast", "animated"));
            movieList.Add(new Movie("Finding Nemo", "animated"));
            movieList.Add(new Movie("Pocahontas", "animated"));
            movieList.Add(new Movie("Star Wars", "scifi"));
            movieList.Add(new Movie("2001: A Space Odessey", "scifi"));
            movieList.Add(new Movie("A Clockwork Orange", "scifi"));
            movieList.Add(new Movie("Forrest Gump", "drama"));
            movieList.Add(new Movie("Good Will Hunting", "drama"));
            movieList.Add(new Movie("Titanic", "drama"));

            
            Console.WriteLine("Welcome to the Movie List Application! \nThe categories are: animated, drama, and scifi.");

            Console.WriteLine("Enter a category: ");

            string input = " ";

            try
            {
                input = Console.ReadLine().ToLower();

            }
            catch(Exception e)
            {
                Console.WriteLine("That is not a valid category.");
            }
            if (input == "drama")
            {
                foreach (var Movie in movieList)
                {
                    if (Movie.Category == "drama")
                    {
                        Console.WriteLine(Movie.Title);
                    }
                }
            }
            else if(input == "animated")
            {
                foreach (var Movie in movieList)
                {
                    if (Movie.Category == "animated")
                    {
                        Console.WriteLine(Movie.Title);
                    }
                }
            }
            else if(input == "scifi")
            {
                foreach (var Movie in movieList)
                {
                    if(Movie.Category == "scifi")
                    {
                        Console.WriteLine(Movie.Title);
                    }
                }
            }
        }
    }
}
