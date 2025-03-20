//Create a class Person with the following properties: Id,
//FirstName, LastName, Age, FavoriteMusicType (Genre enum) and FavoriteSongs

using SongsApp.Domain.Enums;

namespace SongsApp.Domain.Models
{
    public class Person
    {
        private int _Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public GenreEnum FavoriteMusicType { get; set; }

        public List<Song> FavoriteSongs { get; set; } //list of song objects; the default value of this list is null
    
        public Person(string firstName, string lastName, int age, GenreEnum favouriteMusicType)
        {
            _Id = new Random().Next(1, 10000);
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favouriteMusicType;

            //!!!!!
            FavoriteSongs = new List<Song>(); //we must create an empty list, otherwise the value is null and if we try to add new elements we will have null.Add() whick will throw an exception
        }

        public void GetFavSongs()
        {
            if(FavoriteSongs.Count == 0)
            {
                Console.WriteLine("This person hates music");
            }
            else
            {
                foreach(Song song in FavoriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
        }
    }
}
