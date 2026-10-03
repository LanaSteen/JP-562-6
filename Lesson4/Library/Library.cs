using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4.Library
{
	internal class Library
	{

		public Book[] Books { get; set; }
		public Client[] Clients { get; set; }
		public Librarian Librarian { get; set; }
	}
}
