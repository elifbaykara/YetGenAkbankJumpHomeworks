using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    internal class Playlist
    {
        public Playlist(Song firstSong)
        {
            Songs = new List<Song>();
            AddSong(firstSong);
        }

        public Guid Id { get; set; }
        private List<Song> Songs { get; set; }

      
        public void AddSong(Song song)
        {
            if(song != null)
                Songs.Add(song);
        }

        public string GetSongs()
        {

            return string.Join("\n", Songs.Select(song => song.Title));
        }

        public void ShuffleSongs()
        {
            int songCount = Songs.Count;

            Random random = new Random();
            while (songCount > 0)
            {
                songCount--;
                Song song = Songs[songCount];
                
                int randomIndex = random.Next(songCount);
                Song swapSong = Songs[random.Next(songCount)];
                Songs[songCount] = swapSong;
                Songs[randomIndex] = song;
            }
        }

        public void ShowSongs()
        {
            foreach (Song song in Songs)
            {
                Console.WriteLine($"title:{song.Title}");
            }

        }
       
    }
}
