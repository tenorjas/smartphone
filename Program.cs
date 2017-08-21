using System;

namespace smartphone
{
    class Program
    {
        static void Main(string[] args)
        {
            var iPhone = new Smartphone();

            iPhone.ReceivePhoneCall();
            iPhone.MakePhoneCall();
            iPhone.SaveVoiceMail();

            iPhone.TakePicture();
            iPhone.TakeSelfie();
            iPhone.TakeVideo();

            iPhone.SearchLibrary();
            iPhone.PlaySong();
            iPhone.ShufflePlay();
        }
    }
}
