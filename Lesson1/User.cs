using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lesson1
{
	internal class User
	{
		public User()
		{
		}	

		public User(string name, int age, string pass)
		{
			Name = name;
			Age = age;
			Pass = pass;
		}

		public User(string name)
		{
			Name = name;
		}


		public User( int age, string pass)
		{
			Age = age;
			Pass = pass;
		}
	


		//overload 



		// constructor

		// property

		// method 

		// feald

		//  full property



		public string Name { get; set; }


		private int _age; /// save  20

		public int Age
		{
			get { return _age; }
			set { 
			  if(value < 0)
				{
					Console.WriteLine("Age can't be negative");
				}
				else { _age = value; }
			}
		}





		private string _pass;

		

		public string Pass
		{
			get { return _pass; }
			set { 
			  if(value.Length < 8)
				{
					Console.WriteLine("Password must be at least 8 characters");
				}
				else
				{
					_pass = value;
				}
			
			}
		}



		public string[] Colors { get; set; }


		public void DisplayInfo()
		{
			Console.WriteLine($" {Name}, {Age}, {Pass}");
		}



		public void Print(string name)
		{
			Console.WriteLine(name);
		}
		public void Print(string name, string name2)
		{
			Console.WriteLine(name);
			Console.WriteLine(name2);
		}


		//propfull

	}
}



// oop  
//1.encapsulation
//2.inheritance
//3.polymorphism