using Entity;
namespace DataLayer;
public class DataAccess
{
    public static List<Movie> movies = new List<Movie>()
    {
        new Movie{Id = 1, Name="Toofan", Ryear=2023, Rating =3},
        new Movie{Id = 2, Name="jungle", Ryear=2013, Rating =4},
        new Movie{Id = 3, Name="sanju", Ryear=2022, Rating =5},
        new Movie{Id = 4, Name="Big bull", Ryear=2014, Rating =2},
        new Movie{Id = 5, Name="Laxmi", Ryear=2017, Rating =5}
    };
}
