using System;
namespace MusicApp
{
	public class Song
	{
		public readonly string Artist;
		public readonly string Title;

		public Song(string artist, string title)
		{
			Artist = artist;
			Title = title;
		}

        public override string ToString()
        {
            return $"{Artist}: {Title}";
        }
    }
}

