using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
	internal class User
	{
		public int Id { get; set; }
		public string Name { get; set; }

		private string _email;
		public string Email { get
			{
				return _email;
			} set
			{

				if (!value.Contains("@"))
				{
					Console.WriteLine("error");
				}
				else
				{
					_email = value;
				}
			}
				
				
				}
		public string Password { get; set; }

		public override string ToString()
		{
			return $"{Id}|{Name}|{Email}|{Password}";
		}
	}
}
