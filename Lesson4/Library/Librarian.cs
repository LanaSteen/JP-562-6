using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4.Library
{
	internal class Librarian : Human
	{

		public void AddBook(Book book)
		{
			// Implementation for adding a book to the library
		}

		public void ExceptBorrow()
		{
			Console.WriteLine("Except borrow");
		}

		public string GetName()
		{
			return Name;  // "saxeli"
		}

		
	}
}
