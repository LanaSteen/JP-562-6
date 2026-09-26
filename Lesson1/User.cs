using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
	internal class User
	{
	

		public User(string name, int age, string pass)
		{
			Name = name;
			Age = age;
			Pass = pass;
		}

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



		//propfull

	}
}
