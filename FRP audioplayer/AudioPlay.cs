using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace FRP_audioplayer
{
	class AudioPlay
	{
		private WaveFileReader wave { get; set; }
		private Mp3FileReader mp3 { get; set; }
		private DirectSoundOut output { get; set; }
        private WaveChannel32 chanel;
        

		public AudioPlay(string file = null)
		{
			this.output = new DirectSoundOut();

        }

        public void setAudioData(string fileName)
		{
			this.mp3 = new Mp3FileReader(fileName);
            output.Init(new WaveChannel32(this.mp3));
            this.chanel = new WaveChannel32(this.mp3);
        }

		public void Play(){ output.Play(); }

        public void Pause(){ output.Pause(); }

        public void setVolume(int volume)
        {

            float value = (float)volume / 100;
            //if (value >= 0 && value <= 1)
            //{
            //   chanel.Volume = (float)0;
            //}
        }

        public int getVolume() { return (int)output.Volume*100; }
    }
}
