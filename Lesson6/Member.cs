using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
	internal class Member : IComparable<Member>
	{
		public string Name { get; set; }
		public int Score { get; set; }

		public int CompareTo(Member? other)
		{
			return Score.CompareTo(other.Score);
		}

		public override bool Equals(object? rame)
		{
			return Score == ((Member)rame).Score && Name == ((Member)rame).Name;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string? ToString()
		{
			return $"Name: {Name}, Score: {Score}";
		}


	
	}
}
