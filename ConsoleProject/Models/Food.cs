using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Models
{
	internal class Food
	{

		public int Id { get; set; }
		public string Name { get; set; }

		public string Description { get; set; }

		public override string? ToString()
		{
			return $"{Id}|{Name}|{Description}";
		}
	}
}
