using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Services
{
	internal interface IEmailService
	{
		void SendEmail(string toEmail, string subject, string message);
	}
}
