using ConsoleProject.Exceptions;
using ConsoleProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Repositories
{
	internal class UserRepository
	{
		private readonly string _filePath = @"../../../Data/user.txt";
			
			
			
			///Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "user.txt");



		//"C:\\Users\\l4nst\\Desktop\\JP-562-6\\ConsoleProject\\Data\\user.txt";



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
				user.VerificationCode = line[5];
				user.IsVerified = bool.Parse(line[6]);
				users.Add(user);
			}

			return users;
		}


		public void ChangeFile(List<string> usersInString)
		{
			File.WriteAllText(_filePath, "");
			File.AppendAllLines(_filePath, usersInString);
		}



		public User GetUserByEmail(string email)
		{
			var users = GetAllUsers();

			var user = users.FirstOrDefault(x => x.Email == email);


			return user;

		}



		public void VerifyUser(string email, string verificationCode)
		{
			var users = GetAllUsers();
			var user = users.FirstOrDefault(x => x.Email == email);


			if (user == null)
			{
				//Console.WriteLine("User not found");
				throw new UserNotFoundException("User not found");
				
			}

			if(user.VerificationCode == verificationCode)
			{
				Console.WriteLine("user verified");
				user.IsVerified = true;


				string[] userText = new string[users.Count];


				for (int i = 0; i < users.Count; i++)
				{
					users[i].IsVerified = true;
					userText[i] = users[i].ToString();
				}


				File.WriteAllText(_filePath, string.Empty);

				File.AppendAllLines(_filePath, userText);


				/// update in file IsVerify = true

			}
			else
			{
				//Console.WriteLine("Verification code is not correct");
				throw new InvalidVerificationCodeException();
			}
		}



	}
}
