using System;

namespace smartphone
{
    public interface IAudioPlayer
    {
        // an audio player can:
        // search the music library for the song you want to listen to
        // play the song you want to listen to
        // shuffle songs

        void SearchLibrary();
        void PlaySong();
        void ShufflePlay();
    }
}