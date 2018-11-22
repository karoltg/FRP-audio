using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FRP_audioplayer
{
    class LoadFiles
    {
		public ListofFiles background;
		public ListofFiles environment;

		public FileData fData;

		public LoadFiles()
		{
			this.background = new ListofFiles();
			this.environment = new ListofFiles();
		}

		public void loadBackground()
		{
			Directory.GetFiles(@"/", "*.mp3");

			foreach(string s in Directory.GetFiles(@"background","*.mp3").Select(Path.GetFileName))
			{
				background.Add(new FileData(s));
			}
		}

		public void loadEnvironment()
		{

			foreach (string s in Directory.GetFiles(@"environment", "*.mp3").Select(Path.GetFileName))
			{
				environment.Add(new FileData(s));
			}

			//foreach(string file in Directory.EnumerateFiles("","*.mp3"))
			//{

			//}
		}

	}
}
