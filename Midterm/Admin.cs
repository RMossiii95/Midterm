using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public class Admin : User
    {
        //methods for user class should also work for this class, admin should be able to add, update, and delete movies from the repo
        //1. needs a method that takes the move object as an argument and adds it to the movie repo
        //2. may need to make multiple methods to allow editing of the movies, user should be able to retrieve the movie from the repo, choose a prop to update, add the updated movie to the repo
        //needs to tell the user if the movie was updated and display the updated movie details, if the movie was not found inform the user
        //3. need to be able to allow the admin to remove a selected movie from the repo, inform the admin if the removing was successful
        public void AddMovie(string movieName, string mainActor, string genre, string director, MovieRepo repoToAddTo)
        {           
            repoToAddTo.Movies.Add(new Movie(movieName, mainActor, genre, director));
        }
        public void RemoveMovie(string movieName, MovieRepo repoToRemove)
        {
            List<Movie> newList = new List<Movie>();
            newList = repoToRemove.Movies;
            for (int i = 0; i < newList.Count; i++)
            {
                if(movieName.Equals(newList[i].MovieName))
                {
                    repoToRemove.Movies.Remove(newList[i]);
                }
            }
        }
        public void EditMovie(string movieName, int propertyToChange, string updatedProperty, MovieRepo repoToEdit)
        {
            List<Movie> editedList = new List<Movie>();
            editedList = repoToEdit.Movies;
            for (int i = 0; i < editedList.Count; i++)
            {
                if (movieName.Equals(editedList[i].MovieName))
                {
                    if(propertyToChange == 1)
                    {
                        editedList[i].MovieName = updatedProperty;
                    }
                    else if(propertyToChange == 2)
                    {
                        editedList[i].MainActor = updatedProperty;
                    }
                    else if(propertyToChange == 3)
                    {
                        editedList[i].Genre = updatedProperty;
                    }
                    else if(propertyToChange == 4)
                    {
                        editedList[i].Director = updatedProperty;
                    }
                    else
                    {
                        Console.WriteLine("Property was not found.");
                    }
                }
            }
        }
    }
}
