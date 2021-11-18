using System;
using System.Collections.Generic;
using System.Text;


namespace Midterm
{
    public class User
    {

        public List<Movie> FilterByGenre(string genre, MovieRepo repoToFilter)
        {
            //Filter by genre and give list of all matching movies
            List<Movie> output = new List<Movie>();
            
            
            if (repoToFilter.AcceptedGenres.Contains(genre))
            {
                for (int i = 0; i < repoToFilter.Movies.Count; i++)
                {
                    Movie m = repoToFilter.Movies[i];

                    if(m.Genre == genre)
                    {
                        output.Add(m);
                    }
                }
            }
            else
            {
                Console.WriteLine($"{genre} is not an accepted genre");
                Console.WriteLine("Here is the list of accpetable genres: ");
                foreach(string c in repoToFilter.AcceptedGenres)
                {
                    Console.WriteLine(c);
                }
                
            }
            return output;
        }
        public List<Movie> FilterByMovieName(string name, MovieRepo repoToFilter)
        {
            //filters all movies by name and lists them
            List<Movie> output = new List<Movie>();
            for (int i = 0; i < repoToFilter.Movies.Count; i++)
            {
                Movie m = repoToFilter.Movies[i];

                if (m.MovieName == name)
                {
                    output.Add(m);
                }
            }
            return output;
        }
            
                    
        public List<Movie> FilterByActor(string actor, MovieRepo repoToFilter)
        {
            //lists all movies by given actor
            List<Movie> output = new List<Movie>();
            for (int i = 0; i < repoToFilter.Movies.Count; i++)
            {
                Movie m = repoToFilter.Movies[i];

                if (m.MainActor == actor)
                {
                    output.Add(m);
                }
            }
            return output;
        }
        public List<Movie> FilterByDirector(string director, MovieRepo repoToFilter)
        {
            //filters all movies by a given director
            List<Movie> output = new List<Movie>();
            for (int i = 0; i < repoToFilter.Movies.Count; i++)
            {
                Movie m = repoToFilter.Movies[i];

                if (m.Director == director)
                {
                    output.Add(m);
                }
            }
            return output;
        }
       

    }
}
