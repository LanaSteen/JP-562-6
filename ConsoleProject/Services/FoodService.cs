using ConsoleProject.Models;
using ConsoleProject.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Services
{
	internal class FoodService
	{


		private readonly FoodRepository _foodRepository;

		public FoodService(FoodRepository foodRepository)
		{
			_foodRepository = foodRepository;
		}



		public List<Food> GetAllFoods()
		{
			
			return _foodRepository.GetAllFoods();
		}


	}
}
