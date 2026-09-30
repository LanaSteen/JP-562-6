using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
	internal class Student :Person
	{



		public int Grade { get; set; }

		public override void SayHello()
		{
			Console.WriteLine("Hello from student");
		}

		public override void Walk()
		{
			Console.WriteLine($"{Name} student is walking");
		}


	}
}

//override