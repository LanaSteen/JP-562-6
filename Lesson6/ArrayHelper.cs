using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
	internal static class ArrayHelper
	{

		//public static  void PrintArray(this int[] arr)
		//{
		//	foreach (var item in arr)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}


		//public static void PrintArray(this string[] arr)
		//{
		//	foreach (var item in arr)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}
		//public static void PrintArray(this Member[] arr)
		//{
		//	foreach (var item in arr)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}

		//generic <>


		public static void PrintArray<T>(this T[] arr)
		{
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}



		public static T Find<T>(this T[] arr, T element)
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



		//firstOrDefault
		//lastOrDefault

		//Find 

	}
}



//extension method