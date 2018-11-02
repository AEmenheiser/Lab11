using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie()
            {
                Title = "Blues Brothers",
                Genre = "Comedy",
                GiD = 1,

            };

            Movie movie2 = new Movie()
            {
                Title = "Young Frankenstien",
                Genre = "Comedy",
                GiD = 1,

            };
            Movie movie3 = new Movie()
            {
                Title = "Anchorman",
                Genre = "Comedy",
                GiD = 1,

            };
            Movie movie4 = new Movie()
            {
                Title = "Alien",
                Genre = "Horror",
                GiD = 2,

            };
            Movie movie45 = new Movie()
            {
                Title = "Halloween",
                Genre = "Horror",
                GiD = 2,

            };
            Movie movie5 = new Movie()
            {
                Title = "It Follows",
                Genre = "Horror",
                GiD = 2,

            };
            Movie movie6 = new Movie()
            {
                Title = "Cabin in the woods",
                Genre = "Horror",
                GiD = 2,

            };
            Movie movie7 = new Movie()
            {
                Title = "Indiana Jones",
                Genre = "Action",
                GiD = 3,

            };
            Movie movie8 = new Movie()
            {
                Title = "Mad Max",
                Genre = "Action",
                GiD = 3,

            };
            Movie movie9 = new Movie()
            {
                Title = "Taken",
                Genre = "Action",
                GiD = 3,

            };
            Movie movie10 = new Movie()
            {
                Title = "Amelie",
                Genre = "Foriegn",
                GiD = 4,

            };
            Movie movie11 = new Movie()
            {
                Title = "My Neighbor Totoro",
                Genre = "Foriegn",
                GiD = 4,

            };
            Movie movie12 = new Movie()
            {
                Title = "Martyr",
                Genre = "Foriegn",
                GiD = 4,

            };
            List<Movie> movies = new List<Movie> { };
            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);
            movies.Add(movie4);
            movies.Add(movie5);
            movies.Add(movie6);
            movies.Add(movie7);
            movies.Add(movie8);
            movies.Add(movie9);
            movies.Add(movie10);
            movies.Add(movie11);
            movies.Add(movie12);
            do
            {


                Console.WriteLine($"There are {movies.Count} movies in the list. Which Genre would you like to browse? \n 1 for Comedy \n 2 for Horror \n 3 for Action \n 4 for Foriegn");
                int userInput = Convert.ToInt16(Console.ReadLine());

                foreach (Movie c in movies)
                {
                    if (userInput >= 5 || userInput <= 0)
                    {
                        Console.WriteLine("invalid number");
                        break;
                    }

                    else if (c.GiD == userInput)
                        
                    {

                        Console.WriteLine($"A movie in {c.Genre} is {c.Title}");
                    }

                }

                Console.WriteLine("+++++++++++++++++++++++++++++++");
                Console.WriteLine("would you like to continue? y/n");
            } while (Console.ReadLine() == "y"); Console.WriteLine("have a blessed day");
                    Console.ReadKey();


            







        }
    }
}

