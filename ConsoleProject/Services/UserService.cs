using ConsoleProject.Models;
using ConsoleProject.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Services
{
	internal class UserService 
	{

		private readonly UserRepository _userRepository;

		public UserService(UserRepository userRepository)
		{
			_userRepository = userRepository;
		}


		public void RegisterUser(User user)
		{
			var users = _userRepository.GetAllUsers();
			int maxId = 0;
			if (users.Count != 0)
			{
				maxId= users.Max(u => u.Id);
			}
			user.Id = ++maxId;
			if (user == null)
			{
				Console.WriteLine("User cannot be null.");
				return;
			}

			_userRepository.SaveUser(user);
		}



	}
}
