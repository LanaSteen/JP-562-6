using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
	internal class Mandaturi : Person
	{


		public bool HasLicense { get; set; }

		public override void SayHello()
		{
			Console.WriteLine("Hello from mandaturi");
		}
	}
}
