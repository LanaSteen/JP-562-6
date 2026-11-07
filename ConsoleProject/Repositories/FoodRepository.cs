using ConsoleProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Repositories
{
	internal class FoodRepository
	{

		private readonly string _filePath = @"../../../Data/food.txt";



		public void SaveFood(Food food)
		{
			File.AppendAllLines(_filePath, [food.ToString()]);
		}


		public List<Food> GetAllFoods()
		{

			List<Food> foods = new List<Food>();
			var lines = File.ReadAllLines(_filePath);
			foreach (var item in lines)
			{
				var line = item.Split("|"); // [1, sas, dsd]
				Food food = new Food();
				food.Id = int.Parse(line[0]);
				food.Name = line[1];
				food.Description = line[2];

				foods.Add(food);
			}

			return foods;
		}


		public Food GetFoodById(int id)
		{
			Food food = new Food();

			var foods = GetAllFoods();


			food = foods.FirstOrDefault(x => x.Id == id);

			return food;

		}



		public void DeleteFood(int id)
		{
			var foods = GetAllFoods();
			Food food = new Food();
			food = foods.FirstOrDefault(x => x.Id == id);

			foods.Remove(food);

			string[] foodText = new string[foods.Count];
			for (int i = 0; i < foods.Count; i++)
			{
				foodText[i] = foods[i].ToString();
			}

			File.WriteAllText(_filePath, string.Empty);

			File.AppendAllLines(_filePath, foodText);

		}


		public void UpdateFood(Food food)
		{
			var foods = GetAllFoods();
			Food foodToUpdate = new Food();

			foodToUpdate = foods.FirstOrDefault(x => x.Id == food.Id);


			foodToUpdate.Name = food.Name;
			foodToUpdate.Description = food.Description;


			string[] foodText = new string[foods.Count];


			for (int i = 0; i < foods.Count; i++)
			{
				foodText[i] = foods[i].ToString();
			}


			File.WriteAllText(_filePath, string.Empty);

			File.AppendAllLines(_filePath, foodText);
		}
	}
}
