using System;
using System.Collections.Generic;
using System.Text;

//delegate
  //  func - value
 /// predicate    - bool
 /// action - void
 


namespace Lesson8
{
	internal static class CollectionHelper
	{

		public static void PrintReverse<T>(this IList<T> collection)
		{

			for (int i = collection.Count - 1; i >= 0; i--)
			{
				Console.WriteLine(collection[i]);
			}
		}
		//			•  PrintReverse < T >
		//•	დაბეჭდოს კოლექციის ელემენტები უკუღმა, ბოლო ელემენტიდან პირველამდე. 


		public static T GetLastElement<T>(this IEnumerable<T> collection) 
		{
			T rame = default; 
			foreach (var item in collection)
			{
				rame = item;
			}

			return rame;
		}

		//		•  GetLastElement<T> 
		//•	დააბრუნოს კოლექციის ბოლო ელემენტი.


		public static T GetElement<T>(this IEnumerable<T> collection, T el)
		{
			if (collection.Contains(el))
			{
				return el;
			}

			return default;
		}


		public static List<T> GetElements<T>(this IEnumerable<T> collection, T el) 
			where T : IComparable
		{

			List<T> list = new List<T>();

			foreach (var item in collection)
			{
				if(item.CompareTo(el) < 0)
				{
					list.Add(item);
				}
			}

			return list;
		}

		//შქმენი მეთოდი რომელიც იპოვის პირველ ელემენტს 
		//	კოლექციაში რომელიც აკმაყოფილებს გადაცენულ პირობას


		public static List<T> Filter<T>( this IEnumerable<T> collection, 
			Predicate<T> p)
		{

			List<T> list = new List<T>();


			foreach (var item in collection)
			{
				if (p(item))  // IsGreater
				{
					list.Add((T)item);
				}
			}

			return list;
		}
		


		public static T CustromFInd<T>(this IEnumerable<T> collection,
			Predicate<T> p)
		{
			foreach (var item in collection)
			{
				if (p(item))
				{
					return item;
				}
			}
			return default;
		}

	
	
	  public static List<T> CustomTake<T>(this IEnumerable<T> collection,
			Predicate<T> p, int x)
		{
			List<T> list = new List<T>();

			foreach (var item in collection)
			{
				if(p(item))
				{
					list.Add(item);
				}
				if(list.Count== x)
				{
					return list;
				}
			}




			return default;
		}
	
	
	}
}


//[10,02,20, 30]     >10