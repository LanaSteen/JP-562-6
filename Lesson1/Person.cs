using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
	internal class Person
	{

		public int Age { get; set; }
		public string Name { get; set; }

		public string[] Colors { get; set; }


		public static void SayHelo()
		{
			Console.WriteLine("Hello");
		}


		public  void SayName()
		{
			Console.WriteLine($"{Name}");
		}


	}
}
