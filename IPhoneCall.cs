using System;

namespace smartphone
{
    public interface IPhoneCall
    {
        // the phone can:
        // make phone calls
        // receive phone calls
        // store a voicemail message

        void MakePhoneCall();
        void ReceivePhoneCall();
        void SaveVoiceMail();
        
    }
}