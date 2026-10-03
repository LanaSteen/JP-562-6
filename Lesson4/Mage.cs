using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{
	internal class Mage : GameCharacter
	{
		public override void Attack()
		{
			Console.WriteLine("Mage attacks with fireball!");
		}

		public override void Defend()
		{
			Console.WriteLine("Mage casts a protective shield!");

		}
	}
}
