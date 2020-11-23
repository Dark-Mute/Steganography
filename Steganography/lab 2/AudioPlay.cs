using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace lab_2
{
    class AudioPlay
    {
        SoundPlayer SoundPlayer;
        string audioFile;
        public AudioPlay(string audioFile)
        {
            this.audioFile = audioFile;
        }

        public void Play()
        {
            SoundPlayer = new SoundPlayer(this.audioFile);
            SoundPlayer.Play();
        }

        public void Pause()
        {
            SoundPlayer.Stop();
        }
    }
}
