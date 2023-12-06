using SpotifyClone.Entities;
using SpotifyClone.Services;

namespace SpotifyClone
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string currentDirectory = Directory.GetCurrentDirectory();
            var song1 = new Song("Requiem K. 626","W. A. Mozart","Orchestre national de France", null);
            var song2 = new Song("Sonata No.6 in F Major","L. Beethoven","Fazıl Say","Warner Music");

            var playlist1 = new Playlist(song1);
            playlist1.AddSong(song2);
            Console.WriteLine(playlist1.GetSongs());
            playlist1.ShowSongs();

            playlist1.ShuffleSongs();
            Console.WriteLine(playlist1.GetSongs());

            NotepadService notepadService = new();
            notepadService.WriteToNotepad(playlist1.GetSongs());


        }
    }
}