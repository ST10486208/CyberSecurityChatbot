using System;
using System.Media;
using System.IO;

public static class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            string path = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "greeting.wav"
            );

            if (!File.Exists(path))
            {
                Console.WriteLine("Audio file not found.");
                return;
            }

            SoundPlayer player = new SoundPlayer(path);
            player.Play(); // plays in background (NO waiting)
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error playing audio.");
        }
    }
}