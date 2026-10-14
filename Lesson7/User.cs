using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
	internal class User
	{
		public int Age { get; set; }

		public override string? ToString()
		{
			return $"Age: {Age}	";
		}
	}
}
