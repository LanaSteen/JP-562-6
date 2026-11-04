using ConsoleProject.Menu;
using ConsoleProject.Repositories;
using ConsoleProject.Services;

namespace ConsoleProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UserRepository userRepository = new UserRepository();
			UserService userService = new UserService(userRepository);
			UserMenu userMenu = new UserMenu(userService);

			userMenu.ShowMainMenu();

		}
	}
}
