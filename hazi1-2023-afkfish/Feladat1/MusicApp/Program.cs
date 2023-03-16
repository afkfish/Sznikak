namespace MusicApp;

public class Program
{
    public static void Main(string[] args)
    {
        List<Song> songs = new List<Song>();

        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader("../Input/music.txt"); // TODO: Ide be kell irni az input file helyet pontosan kulonben hiba lesz
            string line;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] songsline = line.Split(";");

                string artist = songsline[0].Trim();

                foreach (string song in songsline)
                {
                    songs.Add(new Song(artist, song.Trim()));
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Hiba volt");
        }
        finally
        {
            if (streamReader != null)
            {
                streamReader.Close();
            }
        }

        foreach (Song song in songs)
        {
            Console.WriteLine(song);
        }
        Console.ReadKey();
    }
}
