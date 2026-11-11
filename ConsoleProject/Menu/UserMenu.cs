using ConsoleProject.Models;
using ConsoleProject.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Menu
{
	internal class UserMenu
	{
		private readonly UserService _userService;

		public UserMenu(UserService userService)
		{
			_userService = userService;
		}


		public void ShowMainMenu()
		{
			Console.WriteLine("Welcome to the User Management System");


		
			string choice = "";

			while(choice != "0")
			{
				Console.WriteLine("1. Register");
				Console.WriteLine("2. Login");
				Console.WriteLine("3. Verify Email");
				Console.WriteLine("0. Exit");
				choice = Console.ReadLine();
				switch (choice)
				{
					case "1":
						ShowRegisterMenu();
						break;
					case "2":
						ShowLoginMenu();
						break;
					case "3":
						ShowVerifyEmailMenu();
						break;

					default:
						Console.WriteLine("Invalid choice. Please try again.");
						break;
				}
			}
		}



		private void ShowVerifyEmailMenu()
		{
			Console.WriteLine("Enter email:");
			string email = Console.ReadLine();
			Console.WriteLine("Enter verification code:");
			string code = Console.ReadLine();
			_userService.VerifyUser(email, code);
		}

		private void ShowRegisterMenu()
		{
			User user = new User();
			Console.WriteLine("Enter username:");
			user.Name = Console.ReadLine();
			Console.WriteLine("Enter email:");
			user.Email = Console.ReadLine();	
			Console.WriteLine("Enter password:");
			user.Password = Console.ReadLine();
			_userService.RegisterUser(user);
		
		}

		private void ShowLoginMenu()
		{
			User user = new User();
			Console.WriteLine("Enter email:");
			user.Email = Console.ReadLine();
			Console.WriteLine("Enter password:");
			user.Password = Console.ReadLine();


			_userService.LoginUser(user.Email, user.Password);


		}



	}
}
