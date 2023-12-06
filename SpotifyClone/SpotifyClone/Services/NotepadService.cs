using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Services
{
    internal class NotepadService
    {
        public void WriteToNotepad(string data)
        {
            File.WriteAllText("C:\\Users\\elif\\Desktop\\playlists.txt", data);
        }
    }
}
