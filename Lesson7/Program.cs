namespace Lesson7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = [20, 60, 30];

            //ArrayHelper.Print(numbers);


			numbers.Print();


			string[] strings = ["Hello", "World", "Goodbye"];
			strings.Print();



			User[] users = [new User() { Age = 20 }, new User() { Age = 20 }];

			users.Print();


			List<int> list = new List<int>{ 20, 60, 30 };
			                                //0   1 
			list.Print();



			//Dictionary<string, int> dictionary = new Dictionary<string, int>();
			//dictionary.Add("hello", 20);
			//dictionary.Add("world", 30);
			//dictionary.Add("goodbye", 40);

			//dictionary.Add("goodbye", 40);

			//Console.WriteLine(dictionary["hello"]);



			//Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
			//keyValuePairs.Add(1, 20);


			Dictionary<int, string>  hotLine = new Dictionary<int, string>();

			hotLine.Add(1, "5994565544");
			hotLine.Add(2, "65989898");





			Dictionary<string, string> translator = new Dictionary<string, string>();

			translator.Add("Attendance", "დასწრებები");
			translator.Add("Group attendance", "ჯგუფური დასწრებები");

		
		    
		
			Dictionary<string, string[]> dict = new Dictionary<string, string[]>();

			dict.Add("JP_562_6", ["dsds", "dsdsd", "dfdf"]);
			dict.Add("JP_562_7", ["dsds", "dsdsd", "dfdf"]);
			dict.Add("JP_562_8", ["dsds", "dsdsd", "dfdf"]);

			if (!dict.ContainsKey("JP_562_9"))
			{
				dict.Add("JP_562_9", ["dsds", "dsdsd", "dfdf"]);
			}
			

			foreach (var item in dict)
			{
				Console.Write(item.Key);
				Console.Write("-");
				//Console.Write (item.Value);
				foreach (var item1 in item.Value)
				{
					Console.WriteLine(item1);
				}
			}


		}
	}
}
