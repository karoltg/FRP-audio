using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRP_audioplayer 
{
    class FileData
    {
		public string fullFileName { get; set; }
		public string fileName { get; set; }
		public string fileExtension { get; set; }
		public string filePath { get; set; }

		public FileData() { }
		public FileData(string fullFileName = null, string fileName = null, string fileExtension = null, string filePath = null)
		{
			this.fullFileName = fullFileName;
			this.fileName = fileName;
			this.fileExtension = fileExtension;
			this.filePath = filePath;
		}

    }
}
