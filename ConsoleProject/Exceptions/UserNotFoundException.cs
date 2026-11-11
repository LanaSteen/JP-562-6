using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Exceptions
{
	internal class UserNotFoundException : Exception
	{
		public UserNotFoundException() : base("User not found.")
		{
		}

		public UserNotFoundException(string? message) : base(message)
		{
		}
	
	}
}
