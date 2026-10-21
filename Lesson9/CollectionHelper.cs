using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
	internal static class CollectionHelper
	{
		//ჯენერიკი
		public static void PrintCollection<T>(this IEnumerable<T> arrr) 
		{
			foreach (var item in arrr)
			{
				Console.WriteLine(item);
			}
		}



		//ისეთე მეთოდი რომელიც იმუშავებს ყველა
		//კოლაქციაზე ყველა ტიპის ელემენტებით 

		//და იპოვეთ ელემენტი რომელიც პარამერად გადაეცა

		public static T Findelement<T>(this IEnumerable<T> arr, T element)
		{
			foreach (var item in arr)
			{
				if (item.Equals(element))
				{
					return item;
				}
			}
			return default;
		}



		public static List<T> Findelements<T>(this IEnumerable<T> arr,
			Predicate<T> pred) 
		{
			List<T> result = new List<T>();
			foreach (var item in arr)
			{
				if (pred(item))
				{
					result.Add(item);
				}
			}
			return result;
		}


	}
}



//this   - Exception method