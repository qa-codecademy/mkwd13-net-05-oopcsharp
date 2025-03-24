using QA.SeeSharp.RentalApp.Data.Database;
using QA.SeeSharp.RentalApp.Data.Models;

namespace QA.SeeSharp.RentalApp.Business.Services
{
    public class MovieService
    {
        private MovieDataService _movieDataService;
        private MenuService _menuService;
        public MovieService()
        {
            _movieDataService = new MovieDataService();
            _menuService = new MenuService();
        }

        public void ViewMovieList(User user)
        {
            string errorMessage = string.Empty;
            var movies = new List<Movie>();
            bool isFinished = false;
            while (!isFinished)
            {
                _menuService.ErrorMessage(errorMessage);
                if (movies.Count != 0)
                {
                    PrintMoviesInfo(movies);
                }
                else
                {
                    Console.WriteLine("No videos available with that filtering options");
                }
                _menuService.OrderingMenu();
                bool isValidSelection = int.TryParse(Console.ReadLine(), out int selection);
                switch (selection)
                {
                    case 1:
                        movies = _movieDataService.GetAllMovies();
                        break;
                    case 2:
                        movies = _movieDataService.OrderByGenre();
                        break;
                    case 4:
                        movies = _movieDataService.OrderByReleaseDate();
                        break;
                    case 5:
                        // TODO: Get movies by year of release
                        bool isValidYear = int.TryParse(Console.ReadLine(), out int year);
                        if(!isValidYear)
                        {
                            errorMessage = "Not a valid year";
                            continue;
                        }
                        movies = _movieDataService.GetByYear(year);
                        break;
                    case 6:
                        movies = _movieDataService.OrderByAvailability();
                        break;
                    case 7:
                        movies = _movieDataService.GetAvailableMovies();
                        break;
                    case 8:
                        // TODO: Search videos by title
                        string titlePart = Console.ReadLine();
                        movies = _movieDataService.SearchMoviesByName(titlePart);
                        break;
                    case 9:
                        try
                        {
                            RentMovie(user);
                        }
                        catch (Exception ex)
                        {
                            errorMessage = ex.Message;
                        }
                        break;
                    case 0:
                        isFinished = !isFinished;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
            }
        }

        private void RentMovie(User user)
        {
            Console.Write("Enter movie id: ");
            bool isValidIdSelection = int.TryParse(Console.ReadLine(), out int idSelected);
            if(!isValidIdSelection)
            {
                Console.WriteLine("Not a valid Id");
                return;
            }
            var movie = _movieDataService.GetMovieById(idSelected);
            if (movie != null)
            {
                var listOfRentedMovieIds = user.RentedMovies.Select(rental => rental.Movie.Id).ToList();
                if (listOfRentedMovieIds.Contains(idSelected))
                {
                    throw new Exception($"Already rented {movie.Title} please return it first");
                }

                if (!movie.IsAvailable)
                {
                    throw new Exception($"Movie {movie.Title} is not available at the moment.");
                }
                // Confirmation
                Console.WriteLine($"Are you sure you want to rent {movie.Title}? y/n");
                string confirm = Console.ReadLine();
                if (confirm == "n")
                {
                    return;
                }
                // End confirmation

                Console.WriteLine("Renting movie please wait...");
                movie.Quantity--;
                if (movie.Quantity == 0)
                {
                    movie.IsAvailable = !movie.IsAvailable;
                }
                user.RentedMovies.Add(new RentalInfo(movie));
                Console.WriteLine("Successfuly rented movie");
                Thread.Sleep(3000);
            }
            else
            {
                throw new Exception($"No movie was fount with {idSelected} id");
            }
        }

        private void PrintMoviesInfo(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                string availability = movie.IsAvailable ? "Yes" : "No";
                Console.WriteLine(string.Format("Rent id: {0} Title: {1} Release date: {2} Genre: {3} Available: {4}, Quantity: {5}",
                    movie.Id, movie.Title, movie.ReleaseDate.ToString("MMMM dd yyyy"), movie.Genre, availability, movie.Quantity));
            }
        }

        public void ViewRentedVideos(User user)
        {
            string errorMessage = string.Empty;
            var rentals = user.RentedMovies;
            bool isActive = false;
            while (!isActive)
            {
                try
                {
                    _menuService.ClearScreen();
                    _menuService.ErrorMessage(errorMessage);
                    if (rentals.Count != 0)
                    {
                        PrintMoviesInfo(rentals.Select(_rentals => _rentals.Movie).ToList());
                    }
                    else
                    {
                        Console.WriteLine("You have not rented any videos");
                    }
                    _menuService.RentedMenu();
                    bool isValidSelection = int.TryParse(Console.ReadLine(), out int selection);
                    switch (selection)
                    {
                        case 1:
                            rentals = user.RentedMovies;
                            break;
                        case 2:
                            ReturnMovie(user);
                            break;
                        case 0:
                            isActive = !isActive;
                            break;
                        default:
                            errorMessage = "Invalid input";
                            break;
                    }
                }
                catch (Exception ex)
                {
                    errorMessage = ex.Message;
                }
            }
        }

        private void ReturnMovie(User user)
        {
            if (user.RentedMovies.Count == 0)
            {
                Console.WriteLine("You dont have any rented videos");
                return;
            }
            Console.WriteLine("Enter movie id in order to return a video");
            bool isValidMovieId = int.TryParse(Console.ReadLine(), out int movieId);
            if (!isValidMovieId)
            {
                Console.WriteLine("Not a valid input");
                return;
            }

            var rental = user.RentedMovies.FirstOrDefault(_rental => _rental.Movie.Id == movieId);
            Console.WriteLine("Processing");
            if (rental != null)
            {
                rental.DateReturned = DateTime.Now;
                var movie = _movieDataService.GetMovieById(movieId);
                if (movie.Quantity == 0)
                {
                    movie.IsAvailable = !movie.IsAvailable;
                }
                movie.Quantity += 1;

                user.RentedMoviesHistory.Add(rental);
                user.RentedMovies.Remove(rental);

                Console.WriteLine("Successfuly returned.");
                Thread.Sleep(3000);
                return;
            }

            throw new Exception("You do not have that movie rented. Please enter valid movie id");
        }

        public void ViewRentedHistoryVideos(User user)
        {
            if (user.RentedMoviesHistory.Count == 0)
            {
                throw new Exception("You do not have any videos rented history.");
            }

            foreach (var rental in user.RentedMoviesHistory)
            {
                Console.WriteLine($"{rental.Movie.Title} rented from {rental.DateRented} to {rental.DateReturned}");
            }

            Console.WriteLine("To go back press 0");
            bool isValidSelection = int.TryParse(Console.ReadLine(), out int selection);
            if(!isValidSelection)
            {
                Console.WriteLine("Not a valid selection, returning to previous menu");
            }

            if (selection == 0)
            {
                return;
            }
        }

    }
}
