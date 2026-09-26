using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
	internal class Product
	{
		public Product()
		{
		}

		public string Name { get; set; }
		private decimal _price;

		public decimal Price
		{
			get { return _price; }
			set { 
			  if(value >= 0)
				{
					_price = value;
				}
				else
				{
					Console.WriteLine("Price can't be negative");
				}
			}
		}


		public string Brand { get; set; }

		public Color[] Colors { get; set; }


		public void DisplayInfo()
		{
			Console.WriteLine($" {Name}, {Price}, {Brand}");
		}

		public override string? ToString()
		{
			return $"{Name}, {Price}, {Brand}";
		}
	}
}



public enum Color
{
   Red,
   Green,
   Blue
}