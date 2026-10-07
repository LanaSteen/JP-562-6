using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Game
{
	internal abstract class Sprite
	{

		public int X { get; set; }
		public int Y { get; set; }

		public string Name { get; set; }

		public void Draw()
		{
			Console.SetCursorPosition(X, Y);
			Console.WriteLine(Name);
		}
	}
}
