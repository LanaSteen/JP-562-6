using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Exceptions
{
	internal class InvalidVerificationCodeException : Exception
	{
		public InvalidVerificationCodeException() : base("Invalid verification code.")
		{
		}
		public InvalidVerificationCodeException(string? message) : base(message)
		{
		}
	
	}
}
