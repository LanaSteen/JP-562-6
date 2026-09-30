using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
	internal class Lecturer : Person
	{


		public string Subject { get; set; }

		public int WorkExperience { get; set; }

		public int WorkingHours { get; set; }

		public override void SayHello()
		{
			throw new NotImplementedException();
		}
	}
}




//movie studio 


// actor
// director
// producer
// film