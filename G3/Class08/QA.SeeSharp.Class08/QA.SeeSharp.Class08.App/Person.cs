namespace QA.SeeSharp.Class08.App
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }

        public List<Song> FavoriteSongs { get; set; }

        public Person()
        {
            FavoriteSongs = new List<Song>();
        }

        public void GetFavSongs()
        {
            if (FavoriteSongs.Count == 0)
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
