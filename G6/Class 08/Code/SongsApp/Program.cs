using SongsApp.Domain.Models;
using SongsApp.Domain.Enums;

Person person = new Person("Petko", "Petkovski", 25, GenreEnum.Rock);
person.GetFavSongs();

//person.FavoriteSongs is our list and we can use Add to add new songs
person.FavoriteSongs.Add(new Song("Song1", 3.20, GenreEnum.Rock));
person.FavoriteSongs.Add(new Song("Song2", 2.70, GenreEnum.Rock));
person.GetFavSongs();