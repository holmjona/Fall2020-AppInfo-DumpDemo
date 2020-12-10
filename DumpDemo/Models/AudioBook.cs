using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumpDemo.Models {
    class AudioBook:Book {
		private int _Length;

		public int Length {
			get { return _Length; }
			set { _Length = value; }
		}

	}
}
