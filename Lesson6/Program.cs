namespace Lesson6
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region hw
			//Console.WriteLine("Hello, World!");


			//Member meb1 = new();
			//Member meb2 = new();

			//meb1.Name = "saxeli 1";
			//meb2.Name = "saxeli 2";
			//meb1.Score = 100;
			//meb2.Score = 20;

			//Member meb3 = new();
			//Member meb4 = new();

			//meb3.Name = "saxeli 3";
			//meb4.Name = "saxeli 4";
			//meb3.Score = 150;
			//meb4.Score = 25;

			//Member meb5 = new() {Name = "saxeli 5", Score = 50};


			//List<Member> members = new List<Member>();
			//members.Add(meb1);
			//members.Add(meb2);
			//members.Add(meb3);
			//members.Add(meb4);
			//members.Add(meb5);

			//members.Sort();




			//foreach (var item in members)
			//{
			//	Console.WriteLine(item);
			//}


			//for (int i = 0; i < 3; i++)
			//{
			//	Console.WriteLine(members[i]);
			//}


			//Console.WriteLine(members[members.Count-1]);


			//members.Reverse();
			//Console.WriteLine(members[0]);

			////meb1.CompareTo(meb2);  // 1   -1   0 
			////Sort

			#endregion



			//ArrayHelper ah = new ArrayHelper();
			//ah.PrintArray([20,30,66050]);


			int[] numnbers = { 20, 15, 30 };

			numnbers.PrintArray();

			int[] x = [10];
			
			x.PrintArray();

			string[] names = { "saxeli", "jane", "joe" };
			names.PrintArray();



			Member[] members = [];
			members.PrintArray();



			Console.WriteLine(names.Find("s"));




		}



	}
}
