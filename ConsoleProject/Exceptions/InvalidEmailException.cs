using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Exceptions
{
	internal class InvalidEmailException : Exception
	{
		public InvalidEmailException() : base("Invalid email address.")
		{
		}
		

		public InvalidEmailException(string? message) : base(message)
		{
		}
	}
}
