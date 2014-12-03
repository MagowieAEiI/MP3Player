using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MP3Player
{
    class Mp3File
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength,
            int hwndCallback);

        public void Open(string file)
            {
                string command = "close CurrentMp3";
                mciSendString(command, null, 0, 0);
                command = "open \"" + file + "\" type MPEGVideo alias CurrentMp3";
                mciSendString(command, null, 0, 0);
            }

        public void Play()
            {
                string command = "play CurrentMp3";
                mciSendString(command, null, 0, 0);
            }

        public void Stop()
            {
                string command = "stop CurrentMp3";
                mciSendString(command, null, 0, 0);
            }
        public void Pause()
            {
                string command = "pause CurrentMp3";
                mciSendString(command, null, 0, 0);
            }

        public void ChangeVolume(double factor)
            {
                string command = "setaudio CurrentMp3 volume to " + factor;
                mciSendString(command, null, 0, 0);
            }
           
    }
}
