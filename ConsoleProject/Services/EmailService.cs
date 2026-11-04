
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace ConsoleProject.Services
{
//https://myaccount.google.com/apppasswords
//Microsoft.Extensions.Configuration
//Microsoft.Extensions.Configuration.Json
//dotnet add package Microsoft.Extensions.DependencyInjection
//dotnet add package Microsoft.Extensions.Logging
//dotnet add package Microsoft.Extensions.Logging.Console
	public class EmailService : IEmailService
	{
		private readonly IConfiguration _configuration;
		private readonly ILogger<EmailService> _logger;

		public EmailService(IConfiguration configuration, ILogger<EmailService> logger)
		{
			_configuration = configuration;
			_logger = logger;
		}

		public void SendEmail(string toEmail, string subject, string message)
		{
			try
			{
				var smtpServer = _configuration["EmailSettings:Server"];
				var port = int.Parse(_configuration["EmailSettings:Port"] ?? "587");
				var senderEmail = _configuration["EmailSettings:SenderEmail"];
				var senderName = _configuration["EmailSettings:SenderName"] ?? "Console App";
				var password = _configuration["EmailSettings:Password"];

				using var client = new SmtpClient(smtpServer, port)
				{
					Credentials = new NetworkCredential(senderEmail, password),
					EnableSsl = true
				};

				using var mailMessage = new MailMessage
				{
					From = new MailAddress(senderEmail!, senderName),
					Subject = subject,
					Body = message,
					IsBodyHtml = true
				};

				mailMessage.To.Add(toEmail);

				client.SendMailAsync(mailMessage);
				_logger.LogInformation("მეილი წარმატებით გაიგზავნა მისამართზე: {Email}", toEmail);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "მეილის გაგზავნა ვერ მოხერხდა მისამართზე: {Email}", toEmail);
				throw;
			}
		}
	}
}
