using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Exceptions
{
	internal class EmailNullexception : Exception
	{
		public EmailNullexception() : base("Email cannot be null.")
		{
		}

		public EmailNullexception(string? message) : base(message)
		{
		}
	}
}
