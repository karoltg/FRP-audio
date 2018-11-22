using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRP_audioplayer
{
    class ListofFiles : List<FileData>, ICloneable
    {
		public object Clone()
		{
			throw new NotImplementedException();
		}
    }
}
