using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{
	internal abstract class GameCharacter
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public int Level { get; set; }

		//Name, Health, Level



		public abstract void Attack();
		public abstract void Defend();


		public virtual void DisplayInfo()
		{
			Console.WriteLine($"Name: {Name}, Health: {Health}, Level: {Level}");
		}

	}
}


// აბსტრაქტულ კლასს რა არ შეუძლია
// აბსტრაქტული  მეთოდს არრ აქვს ბოდი - იმპლემენტაცია