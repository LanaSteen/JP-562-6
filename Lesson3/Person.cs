using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
	internal abstract class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }


		public virtual void Walk()
		{
			Console.WriteLine($"{Name} is walking");
		}

		public abstract void SayHello(); // Abstract method, must be implemented in derived classes
	}
}
//abstract