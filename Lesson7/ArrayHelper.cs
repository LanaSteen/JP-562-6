using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
	internal static class ArrayHelper
	{



		public static void Print<T> (this T[] array)
		{
			foreach (var item in array)
			{
				Console.WriteLine(item);
			}
		}
		public static void Print<T>(this List<T> array)
		{
			foreach (var item in array)
			{
				Console.WriteLine(item);
			}
		}



		public static void Print<T>(this IEnumerable<T> array)
		{
			foreach (var item in array)
			{
				Console.WriteLine(item);
			}
		}



		public static int FindIndex<T>(this ICollection<T> array, T element)
		{
			for (int i = 0; i < array.Count; i++)
			{
				if (array.Contains(element))
				{
					return i;
				}
			}

			return -1;
		}


	}
}
