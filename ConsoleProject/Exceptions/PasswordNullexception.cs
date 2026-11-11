using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Exceptions
{
	internal class PasswordNullexception : Exception
	{
		public PasswordNullexception() : base("Email cannot be null.")
		{
		}

		public PasswordNullexception(string? message) : base(message)
		{
		}
	}
}
