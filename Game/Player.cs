using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Game
{
	internal class Player : Sprite, IAlive
	{

        public int Health  {get; set; }
		public void Die()
		{
			Console.WriteLine("Game Over");
		}

		public void LooseHealth()
		{
			Health--;
			Console.WriteLine("Health lost");
		}
	}
}
