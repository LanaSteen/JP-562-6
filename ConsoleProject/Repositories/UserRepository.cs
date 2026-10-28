using ConsoleProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Repositories
{
	internal class UserRepository
	{
		private readonly string _filePath = "C:\\Users\\l4nst\\Desktop\\JP-562-6\\Lesson10\\Data\\users.txt";



		public void SaveUser(User user)
		{
			File.AppendAllLines(_filePath, [user.ToString()]);
		}


		public List<User> GetAllUsers()
		{

			List<User> users = new List<User>();
			var lines = File.ReadAllLines(_filePath);
			foreach (var item in lines)
			{
				var line = item.Split("|"); // [1, sas, dsd]
				User user = new User();
				user.Id = int.Parse(line[0]);
				user.Name = line[1];
				user.Email = line[2];
				user.Password = line[3];
				user.IsLogged = bool.Parse(line[4]);
				users.Add(user);
			}

			return users;
		}




	}
}
