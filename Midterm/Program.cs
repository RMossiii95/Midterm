using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public class Program
    {
        //static void Main(string[] args)
        public static void ProgramMockbuster()
        {

            //user interface
            //controls the application, shows menus, access funtionality built out in the other classes
            //1. if the client is a user, they should only have access to functions specified as:
            //a. filter by movie name
            //b. filter bu main actor
            //c. filter bu genre
            //d. filter by director
            //only matches should be displayed to the console. displayed items display all properties of that movie
            //if the client is an admin they shoyld have access to the same functionality
            //admins also can add new movies, edit, and delete movies.
            //should be returned to the menu once the user opts to quit

            //client validation, any bad inputs should inform the user

            //unit test after all is completed.
            
            bool tryAgain = true;
            while (tryAgain == true)
            {
                MovieRepo listOfMovies = new MovieRepo();

                Console.WriteLine("Welcome to the MockBuster! Please choose an option:");
                Console.WriteLine("1. If you are a user please select option 1.");
                Console.WriteLine("2. If you are a admin please select option 2.");
                Console.WriteLine("3. To Exit");
                string userChoice = Console.ReadLine();

                


                if (userChoice == "1")
                {
                    User newUser = new User();
                    Console.WriteLine("Welcome user! Please select one of these options!");
                    Console.WriteLine("1. Search by movie name.");
                    Console.WriteLine("2. Search by main actor");
                    Console.WriteLine("3. Search by genre.");
                    Console.WriteLine("4. Search by director");
                    Console.WriteLine("5. To view the list of movies.");
                    Console.WriteLine("6. To return to the main menu.");
                    Console.WriteLine("7. To Exit");
                    string userMenuChoice = Console.ReadLine();
                    


                    if (userMenuChoice == "1")
                    {
                        Console.WriteLine("Please enter the name of the movie.");

                        string userInputMovieName = Console.ReadLine();
                        List<Movie> filteredMovieList = newUser.FilterByMovieName(userInputMovieName, listOfMovies);
                        //filteredMovieList[0].ToString();

                        for (int i = 0; i < filteredMovieList.Count; i++)
                        {
                            Console.WriteLine(filteredMovieList[i].ToString());
                            
                        }
                        

                    }
                    else if (userMenuChoice == "2")
                    {
                        Console.WriteLine("Please enter the Main Actor.");
                        string userInputMainActor = Console.ReadLine();
                        List<Movie> filteredMovieList = newUser.FilterByActor(userInputMainActor, listOfMovies);

                        for (int i = 0; i < filteredMovieList.Count; i++)
                        {
                            Console.WriteLine(filteredMovieList[i].ToString());
                        }
                    }
                    else if (userMenuChoice == "3")
                    {
                        Console.WriteLine("Please enter the Genre.");
                        string userInputGenre = Console.ReadLine();
                        List<Movie> filteredMovieList = newUser.FilterByGenre(userInputGenre, listOfMovies);

                        for (int i = 0; i < filteredMovieList.Count; i++)
                        {
                            Console.WriteLine(filteredMovieList[i].ToString());
                        }
                    }
                    else if (userMenuChoice == "4")
                    {
                        Console.WriteLine("Please enter the Director's name.");
                        string inputDirector = Console.ReadLine();
                        List<Movie> filteredMovieList = newUser.FilterByDirector(inputDirector, listOfMovies);

                        for (int i = 0; i < filteredMovieList.Count; i++)
                        {
                            Console.WriteLine(filteredMovieList[i].ToString());
                        }
                    }
                    else if (userMenuChoice == "5")
                    {
                        listOfMovies.PrintMovies();
                    }
                    else if (userMenuChoice == "6")
                    {
                        tryAgain = true;
                    }
                    else if (userMenuChoice == "7")
                    {
                        tryAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("That input was not correct, please try again.");

                    }

                }
                

                else if (userChoice == "2")
                {
                    Admin newAdmin = new Admin();
                    Console.WriteLine("Welcome admin! Please select one of these options!");
                    Console.WriteLine("1. Search by movie name.");
                    Console.WriteLine("2. Search by main actor.");
                    Console.WriteLine("3. Search by genre.");
                    Console.WriteLine("4. Search by director.");
                    Console.WriteLine("5. Add a movie to the list.");
                    Console.WriteLine("6. Delete a movie from the list.");
                    Console.WriteLine("7. Edit a movie on the list.");
                    Console.WriteLine("8. To view the list of movies.");
                    Console.WriteLine("9. To return to the main menu.");
                    Console.WriteLine("10. To Exit.");
                    string adminMenuChoice = Console.ReadLine();


                    if (adminMenuChoice == "1")
                    {
                        Console.WriteLine("Please enter the name of the movie.");
                        string adminInputMovieName = Console.ReadLine();

                        List<Movie> filteredMovieList = newAdmin.FilterByMovieName(adminInputMovieName, listOfMovies);
                        //filteredMovieList[0].ToString();

                        for (int i = 0; i < filteredMovieList.Count; i++)
                        {
                            Console.WriteLine(filteredMovieList[i].ToString());
                        }

                    }
                    else if (adminMenuChoice == "2")
                    {
                        Console.WriteLine("Please enter the Main Actor.");
                        string adminInputMainActor = Console.ReadLine();

                        List<Movie> filteredMovieList = newAdmin.FilterByActor(adminInputMainActor, listOfMovies);

                        for (int i = 0; i < filteredMovieList.Count; i++)
                        {
                            Console.WriteLine(filteredMovieList[i].ToString());
                        }
                    }
                    else if (adminMenuChoice == "3")
                    {
                        Console.WriteLine("Please enter the Genre.");
                        string adminInputGenre = Console.ReadLine();

                        List<Movie> filteredMovieList = newAdmin.FilterByGenre(adminInputGenre, listOfMovies);

                        for (int i = 0; i < filteredMovieList.Count; i++)
                        {
                            Console.WriteLine(filteredMovieList[i].ToString());
                        }
                    }
                    else if (adminMenuChoice == "4")
                    {
                        Console.WriteLine("Please enter the Director's name.");
                        string adminInputDirector = Console.ReadLine();

                        List<Movie> filteredMovieList = newAdmin.FilterByDirector(adminInputDirector, listOfMovies);

                        for (int i = 0; i < filteredMovieList.Count; i++)
                        {
                            Console.WriteLine(filteredMovieList[i].ToString());
                        }
                    }
                    else if (adminMenuChoice == "5")
                    {
                        Console.WriteLine("Please enter the name of the movie:");
                        string newMovieName = Console.ReadLine();

                        Console.WriteLine("Please enter the main actor:");
                        string newMainActor = Console.ReadLine();

                        Console.WriteLine("Please enter the genre:");
                        string newGenre = Console.ReadLine();

                        Console.WriteLine("Please enter the name of the director:");
                        string newDirector = Console.ReadLine();

                        newAdmin.AddMovie(newMovieName, newMainActor, newGenre, newDirector, listOfMovies);
                        listOfMovies.PrintMovies();


                    }
                    else if (adminMenuChoice == "6")
                    {
                        Console.WriteLine("Please enter the name of the movie you would like to remove:");
                        string movieToRemove = Console.ReadLine();

                        newAdmin.RemoveMovie(movieToRemove, listOfMovies);
                        Console.WriteLine("The movie was removed, here is the updated list:");
                        listOfMovies.PrintMovies();
                    }
                    else if (adminMenuChoice == "7")
                    {
                        Console.WriteLine("Please enter the name of the movie you would like to edit:");
                        string movieToEdit = Console.ReadLine();

                        Console.WriteLine("Please enter which property you would like to edit:\n1. Movie Name \n2. Main Actor \n3. Genre \n4. Director");
                        int propertyToChange = int.Parse(Console.ReadLine());

                        Console.WriteLine("What would you like to change the property to?");
                        string updatedProperty = Console.ReadLine();

                        newAdmin.EditMovie(movieToEdit, propertyToChange, updatedProperty, listOfMovies);
                        Console.WriteLine("The movie was updated!");
                        listOfMovies.PrintMovies();
                    }
                    else if (adminMenuChoice == "8")
                    {
                        listOfMovies.PrintMovies();
                    }
                    else if (adminMenuChoice == "9")
                    {
                        tryAgain = true;
                    }
                    else if (adminMenuChoice == "10")
                    {
                        tryAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("That input was not correct, please try again.");

                    }

                }
                
                else if (userChoice == "3")
                {
                    tryAgain = false;
                }
                else
                {
                    Console.WriteLine("That input was not correct, please try again.");

                }

            }
        }
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string userinput = Console.ReadLine();
            return userinput;
        }
        



    }
}
