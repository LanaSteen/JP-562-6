using ConsoleProject.Menu;
using ConsoleProject.Repositories;
using ConsoleProject.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConsoleProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IConfiguration configuration = new ConfigurationBuilder()
				.SetBasePath(AppContext.BaseDirectory)
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.Build();
			
			UserRepository userRepository = new UserRepository();
			EmailService emailService = new EmailService(configuration);
			UserService userService = new UserService(userRepository, emailService);
			UserMenu userMenu = new UserMenu(userService);

			userMenu.ShowMainMenu();

		}
	}
}
