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

		public AudioPlay(string file = null)
		{
			//this.wave = null;
			//this.mp3 = null;

			//switch(file.Substring(file.Count()-4,4))
			//{
			//	case (".mp3"): this.mp3 = new Mp3FileReader(file); break;
			//	case (".wav"): this.wave = new WaveFileReader(file); break;
			//	default: break;
			//}

			this.output = new DirectSoundOut();
		}

		public void setAudioData(string fileName)
		{
			this.mp3 = new Mp3FileReader(fileName);
		}

		public void Play()
		{
			
			if(wave != null)
			{
				output.Init(new WaveChannel32(wave));
				output.Play();
			}else if (mp3 != null)
			{
				output.Init(new WaveChannel32(mp3));
				output.Play();
			}

		}



	}
}
