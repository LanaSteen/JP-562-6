using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
	internal class Enemy : Sprite, IComparable<Enemy>
	{
		public int Sthrength { get; set; }

		public int CompareTo(Enemy? other)
		{
			return Sthrength.CompareTo(other.Sthrength);
		}
	}
}
