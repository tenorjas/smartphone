using System;

namespace smartphone
{
    public class Smartphone : IPhoneCall, IAudioPlayer, ICamera
    {
        int callsReceived;
        int callsMade;
        int voicemails;
        int totalPictures;
        int totalVideos;
        public void MakePhoneCall()
        {
            callsMade +=1;
            Console.WriteLine("Making a phone call");
        }

        public void PlaySong()
        {
            Console.WriteLine("Playing a song from the music library");
        }

        public void ReceivePhoneCall()
        {
            callsReceived += 1;
            Console.WriteLine("Receiving a phone call.");
        }

        public void SaveVoiceMail()
        {
            voicemails += 1;
            Console.WriteLine("Missed the call, saving a message to voicemail.");
        }

        public void SearchLibrary()
        {
            Console.WriteLine("Searching the music library for the song we want.");
        }

        public void ShufflePlay()
        {
            Console.WriteLine("Shuffle-playing songs.");
        }

        public void TakePicture()
        {
            totalPictures += 1;
            Console.WriteLine("Taking a picture.");
        }

        public void TakeSelfie()
        {
            totalPictures += 1;
            Console.WriteLine("Taking a selfie.");
        }

        public void TakeVideo()
        {
            totalVideos += 1;
            Console.WriteLine("Recording a video.");
        }
    }
}