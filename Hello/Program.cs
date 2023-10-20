// See https://aka.ms/new-console-template for more information
using Entity;
using bzLayer;

moviesBz bz = new moviesBz();

List<Movie> movies = bz.GetMovies();

if(movies != null)
{
    foreach(var m in movies)
    {
        Console.WriteLine($"{m.Id} {m.Name} {m.Rating} {m.Ryear}");
    }
    else
    {
        {
            Console.WriteLine("No Movies Present");
        }
    }
}

