namespace Online_Radio_Database.Models
{
    public class Song
    {
        private const int SongAndArtistNameMinLength = 3;
        private const int SongNameMaxLength = 30;
        private const int ArtistNameMaxLength = 20;
        private const int MinutesAndSecondsMinValue = 0;
        private const int MinutesMaxValue = 14;
        private const int SecondsMaxValue = 59;

        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public string ArtistName
        {
            get { return this.artistName; }
            set
            {
                if (value.Length < SongAndArtistNameMinLength || value.Length > ArtistNameMaxLength)
                {
                    throw new InvalidArtistNameException();
                }

                this.artistName = value;
            }
        }

        public string SongName
        {
            get { return this.songName; }
            set
            {
                if (value.Length < SongAndArtistNameMinLength || value.Length > SongNameMaxLength)
                {
                    throw new InvalidSongNameException();
                }

                this.songName = value;
            }
        }

        public int Minutes
        {
            get { return this.minutes; }
            set
            {
                if (value < MinutesAndSecondsMinValue || value > MinutesMaxValue)
                {
                    throw new InvalidSongMinutesException();
                }

                this.minutes = value;
            }
        }

        public int Seconds
        {
            get { return this.seconds; }
            set
            {
                if (value < MinutesAndSecondsMinValue || value > SecondsMaxValue)
                {
                    throw new InvalidSongSecondsException();
                }

                this.seconds = value;
            }
        }
    }
}
