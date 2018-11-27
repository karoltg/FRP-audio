using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NAudio;

namespace FRP_audioplayer
{
    class LoadFiles
    {
		public ListofFiles background;
		public ListofFiles environment;
		
		public LoadFiles()
		{
			this.background = new ListofFiles();
			this.environment = new ListofFiles();
		}

		public void loadBackground()
		{
			var v = Directory.GetFiles(@"background","*.mp3");
				
			for(int i = 0; i < v.Length; i++)
			{
				background.Add(new FileData(Path.GetFileName(v[i]),Path.GetFileNameWithoutExtension(v[i]),Path.GetExtension(v[i]),v[i]));
			}
		}

		public void loadEnvironment()
		{
			var v = Directory.GetFiles(@"environment", "*.mp3");

			for (int i = 0; i < v.Length; i++)
			{
				environment.Add(new FileData(Path.GetFileName(v[i]), Path.GetFileNameWithoutExtension(v[i]), Path.GetExtension(v[i]), v[i]));
			}
		}

	}
}
