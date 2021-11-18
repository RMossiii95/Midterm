using System;
using System.Collections.Generic;
using System.Text;


namespace Midterm
{
    public class MovieRepo
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<string> AcceptedGenres { get; set; } = new List<string>();

        public MovieRepo()
        {
            Movies.Add(new Movie("Transformers", "Shia LaBeouf", "Action", "Michael Bay"));
            Movies.Add(new Movie("Step Brothers", "Will Ferrell", "Comedy", "Adam McKay"));
            Movies.Add(new Movie("Spider-Man: Into the Spider-Verse", "Shameik Moore", "Animation", "Peter Ramsay"));
            Movies.Add(new Movie("The Wicker Man", "Nicholas Cage", "Horror", "Robin Hardy"));
            Movies.Add(new Movie("Rashomon", "Toshiro Mifune", "Suspense", "Akira Kurosawa"));
            AcceptedGenres.Add("Action");
            AcceptedGenres.Add("Comedy");
            AcceptedGenres.Add("Animation");
            AcceptedGenres.Add("Horror");
            AcceptedGenres.Add("Suspense");
        }
        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i + 1} {Movies[i].MovieName}");
            }
        }


    }

}
