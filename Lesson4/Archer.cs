using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{
	internal class Archer : GameCharacter      
	{
		public override void Attack()
		{
			Console.WriteLine("Archer attacks with bow!");
		}

		public override void Defend()
		{
			Console.WriteLine("Archer dodges the attack");
		}
	}
}
