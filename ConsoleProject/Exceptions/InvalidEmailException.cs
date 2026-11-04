using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Exceptions
{
	internal class InvalidEmailException : Exception
	{
		public InvalidEmailException()
		{
		}

		public InvalidEmailException(string? message) : base(message)
		{
		}
	}
}
