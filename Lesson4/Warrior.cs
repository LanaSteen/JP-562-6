using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{
	internal class Warrior : GameCharacter
	{
		public override void Attack()
		{
			Console.WriteLine("Warrior attacks with sword!");
		}

		public override void Defend()
		{
			Console.WriteLine("Warrior blocks the attack with shield!");
		}
	}
}
