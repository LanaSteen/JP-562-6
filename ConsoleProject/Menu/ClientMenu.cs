using ConsoleProject.Services;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Menu
{
	internal class ClientMenu
	{

		private readonly FoodService _foodService;
		public ClientMenu(FoodService foodService)
		{
			_foodService = foodService;
		}

		public void ShowMainFoodMenu()
		{
			Console.WriteLine("Welcome to the Food Menu");



			string choice = "";

			while (choice != "0. Exit")
			{
				//Console.WriteLine("1. Register");
				//Console.WriteLine("2. Login");
				//Console.WriteLine("3. Verify Email");
				//Console.WriteLine("0. Exit");

				choice = AnsiConsole.Prompt(new SelectionPrompt<string>()
			   .Title("1. Show Foods, 0. Exit")
			   .AddChoices("1. Show Foods", "0. Exit"));

				//AnsiConsole.MarkupLine($"You selected: [green]{fruit}[/]");
				//choice = Console.ReadLine();



				switch (choice)
				{
					case "1. Show Foods":
						ShowFoodMenu();
						break;
				

					default:
						Console.WriteLine("Invalid choice. Please try again.");
						break;
				}
			}
		}







		private void ShowFoodMenu()
		{
			var foods = _foodService.GetAllFoods();
			foreach (var food in foods)
			{
				Console.WriteLine(food);
			}
		}
	}
}
