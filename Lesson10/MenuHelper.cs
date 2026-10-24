using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
	internal static class MenuHelper
	{

		
		public static void ShowMenu(string path)
		{
			//string path = "C:\\Users\\l4nst\\Desktop\\JP-562-6\\Lesson10\\Data\\users.txt";

			string choose = "0";
			while (choose != "9")
			{
				Console.WriteLine("1. Add user");
				Console.WriteLine("2. Show users");
				Console.WriteLine("3. Find user by id");
				Console.WriteLine("4. Delete All users");
				Console.WriteLine("9. Exit");
				choose = Console.ReadLine();

				switch (choose)
				{
					case "1":

						var maxId = int.Parse(File.ReadAllLines(path).Max(line => line.Split('|')[0]) ?? "0");
						maxId++;
						User user = new User();
						user.Id = maxId;
						Console.WriteLine("Name: ");
						user.Name = Console.ReadLine();
						Console.WriteLine("Password: ");
						user.Password = Console.ReadLine();
						Console.WriteLine("Email: ");
						user.Email = Console.ReadLine();

						File.AppendAllLines(path, new[] { user?.ToString() });


						break;
					case "2":


						var users = File.ReadAllLines(path).ToList();
						foreach (var item in users)
						{
							Console.WriteLine(item);
						}


						break;
					case "3":
						Console.WriteLine("enter Id");
						int id = int.Parse(Console.ReadLine());
						var usersAll = File.ReadAllLines(path).ToList();
						var searchUser = usersAll.FirstOrDefault(x => int.Parse(x.Split('|')[0]) == id);
						Console.WriteLine(searchUser);

						break;
					case "4":
						File.WriteAllText(path, string.Empty);


						break;
				}
			}

		}
	}
}
