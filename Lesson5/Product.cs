using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
	public class Product
	{
		public string? Name { get; set; }
		public decimal Price { get; set; }
		public Category Category { get; set; }

		public List<Color> Color { get; set; } = new List<Color>();
		
		public int Amount { get; set; }

		public override string? ToString()
		{
			return $"Name: {Name}, Price: {Price}, Category: {Category}, Color: {Color}, Amount: {Amount}";
		}
	}
}


public enum Color
{
	Red,
	Blue,
	Green
}


public enum Category
{
	Computer,
	Tablet,
	Phone
}