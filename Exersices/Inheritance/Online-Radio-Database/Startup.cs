using System;
using System.Collections.Generic;
using System.Linq;
using Online_Radio_Database.Models;

namespace Online_Radio_Database
{
    class Startup
    {
        static void Main()
        {
            int numberOfEntries = int.Parse(Console.ReadLine());
            List<Song> playList = new List<Song>();


            for (int i = 0; i < numberOfEntries; i++)
            {
                string[] songInfo = Console.ReadLine().Split(new char[] {';', ':'}, StringSplitOptions.None);
                string artistName = songInfo[0];
                string songName = songInfo[1];
                

                try
                {
                    int minutes = int.Parse(songInfo[2]);
                    int seconds = int.Parse(songInfo[3]);
                    Song song = new Song(artistName, songName, minutes, seconds);

                    playList.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("Invalid song length.");
                }
            }

            Console.WriteLine($"Songs added: {playList.Count}");

            int totalMinutes = playList.Sum(x => x.Minutes);
            int totalSeconds = playList.Sum(x => x.Seconds);

            totalSeconds += totalMinutes*60;

            int finalMinutes = totalSeconds/60;
            int finalSeconds = totalSeconds%60;
            int finalHours = finalMinutes/60;
            finalMinutes = finalMinutes%60;

            Console.WriteLine($"Playlist length: {finalHours}h {finalMinutes}m {finalSeconds}s");
        }
    }
}
