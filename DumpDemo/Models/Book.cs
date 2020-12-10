using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DumpDemo.Models {
    class Book : Reference {
		private string _Author;

		public Book() {

		}
		public Book(string ttl, string pub, int yr, string auth)
			:base(ttl,pub){
			//Title = ttl;
			//Publisher = pub;
			Year = yr;
			Author = auth;
		}

		public string Author {
			get { return _Author; }
			set { _Author = value; }
		}

	}

}
