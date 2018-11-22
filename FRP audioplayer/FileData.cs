using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRP_audioplayer 
{
    class FileData
    {
		private string fullFileName { get; set; }
		private string fileName { get; set; }
		private string fileExtension { get; set; }
		private float fileLength { get; set; }

		public FileData() { }
		public FileData(string fullFileName = null, string fileName = null, string fileExtension = null, float fileLength = 0)
		{
			this.fullFileName = fullFileName;
			this.fileName = fileName;
			this.fileExtension = fileExtension;
			this.fileLength = fileLength;
		}

    }
}
