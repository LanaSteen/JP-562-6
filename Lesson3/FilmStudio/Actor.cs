using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3.FilmStudio
{
	internal class Actor : Person
	{
		public Actor(string role)
		{
			Role = role;
		}

		public string Role { get; set; }

	

		public override void SayHello()
		{
			throw new NotImplementedException();
		}
	}
}
