namespace Lesson8
{
	internal class Program
	{
		static void Main(string[] args)
		{



			//			•  PrintReverse < T >
			//•	დაბეჭდოს კოლექციის ელემენტები უკუღმა, ბოლო ელემენტიდან პირველამდე.
			//
			int[] numbers = [10,30,60,80,23,15];


			numbers.CustromFInd(x=> x%8==0 );

			numbers.CustromFInd(x => x > 20);
			numbers.CustomTake(x=> x%8==0, 3);


			var list = numbers.GetElements(30);  ///



			numbers.Filter(delegate(int num)
				{
				return num >10;
			});


			numbers.Filter( num=> num % 2 == 0);

			numbers.Filter(x => x % 5 == 0);



			//შქმენი მეთოდი რომელიც იპოვის პირველ ელემენტს 
			//	კოლექციაში რომელიც აკმაყოფილებს გადაცენულ პირობას

		}








		public static bool deviddesby5(int num)
		{
			return num % 5 == 0;
		}


		public static bool IsGreater(int num)
		{ 
			return num > 10;
		}


		public static bool IsGreater20(int num)
		{
			return num > 20;
		}


	}
}
