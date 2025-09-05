using DemoGitHub;

List<Movie> movies = new List<Movie>
        {
            new Movie { Title = "Inception", Genre = "Sci-Fi", Year = 2010, Rating = 8.8 },
            new Movie { Title = "The Dark Knight", Genre = "Action", Year = 2008, Rating = 9.0 },
            new Movie { Title = "Interstellar", Genre = "Sci-Fi", Year = 2014, Rating = 8.6 },
            new Movie { Title = "Parasite", Genre = "Thriller", Year = 2019, Rating = 8.6 },
            new Movie { Title = "Avengers: Endgame", Genre = "Superhero", Year = 2019, Rating = 8.4 },
            new Movie { Title = "The Godfather", Genre = "Crime", Year = 1972, Rating = 9.2 },
            new Movie { Title = "Forrest Gump", Genre = "Drama", Year = 1994, Rating = 8.8 }
        };

foreach (var m in movies)
{
    Console.WriteLine(m);
}