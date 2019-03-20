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
        private WaveOutEvent outputDevice;


        public AudioPlay(string file = null)
		{
			this.output = new DirectSoundOut();

        }

        public void setAudioData(string fileName)
		{
			this.mp3 = new Mp3FileReader(fileName);
            this.outputDevice = new WaveOutEvent();
            this.outputDevice.Init(mp3);
                    
        }

		public void Play(){ outputDevice.Play(); }

        public void Pause(){ outputDevice.Pause(); }

        public void Stop() { outputDevice.Stop(); }

        public void ClearWaveData() { outputDevice.Dispose(); }

        public void setVolume(int volume) { outputDevice.Volume = (float)volume / 100; }

        public int getVolume() { return (int)output.Volume*100; }
    }
}
