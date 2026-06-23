using System;

interface IMediaPlayer
{
    void Play(string audioType, string fileName);
}

class AdvancedMediaPlayer
{
    public void PlayMp4(string fileName)
    {
        Console.WriteLine("Playing mp4 file: " + fileName);
    }
}

class MediaAdapter : IMediaPlayer
{
    private AdvancedMediaPlayer advancedPlayer = new AdvancedMediaPlayer();

    public void Play(string audioType, string fileName)
    {
        if (audioType.ToLower() == "mp4")
        {
            advancedPlayer.PlayMp4(fileName);
        }
    }
}

class AudioPlayer : IMediaPlayer
{
    private MediaAdapter adapter = new MediaAdapter();

    public void Play(string audioType, string fileName)
    {
        if (audioType.ToLower() == "mp3")
        {
            Console.WriteLine("Playing mp3 file: " + fileName);
        }
        else if (audioType.ToLower() == "mp4")
        {
            adapter.Play(audioType, fileName);
        }
    }
}

class Program
{
    static void Main()
    {
        AudioPlayer player = new AudioPlayer();

        player.Play("mp3", "song.mp3");
        player.Play("mp4", "video.mp4");
    }
}