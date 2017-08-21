using System;

namespace smartphone
{
    public interface ICamera
    {
        // a camera can:
        // take pictures
        // take videos
        // take selfies
        // store photos and videos in memory

        void TakePicture();
        void TakeSelfie();
        void TakeVideo();
    }
}