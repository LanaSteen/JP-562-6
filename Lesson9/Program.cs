namespace Lesson9
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//List<string> list = new List<string>() { "Alice", "Bob", "Bob","Charlie" }; 

			//HashSet<string> names = new HashSet<string>(list);


			//int[] numbers = [20,60,30,50];

			//HashSet<int> nums = new HashSet<int>(numbers);



			//Dictionary<string, string> dict = new Dictionary<string, string>();

			//dict.Add("manager", "123-456-7890");
			//dict.Add("developer", "987-654-3210");



			//string[] names1 = ["Alice", "Bob", "Charlie"];
			//Console.WriteLine(names1[0]);
			//Console.WriteLine(names1[1]);

			//Dictionary<int, string> dict2 = new Dictionary<int, string>();
			//dict2.Add(1, "Manager");
			//dict2.Add(200, "Marketing");
			//dict2.Add(9, "English");

			//Console.WriteLine(dict2[9]); // 



			////Lifo
			//Stack<string> stack = new Stack<string>();

			//stack.Push("Alice");
			//stack.Push("Bob");
			//stack.Push("Charlie");

			//Console.WriteLine(stack.Peek()); // "Charlie"
			//stack.Pop();


			////FiFo
			//Queue<string> queue = new Queue<string>();

			//queue.Enqueue("Alice");
			//queue.Enqueue("Bob");
			//queue.Enqueue("Charlie");


			//Console.WriteLine(queue.Peek()); // "Alice"
			//queue.Dequeue();


			//Console.WriteLine(queue.Peek()); // bob
	
		
		
		
			    //  ICollection
				// ILis
				// iEnumerable
				//
				//
				//
				int[]  nums = [10, 20, 30, 40, 50];


			    nums.Findelements(x => x > 30); /// 30, 40, 50


				nums.Findelement(15); /// 0

			    nums.Where(x => x > 15);



			CollectionHelper.PrintCollection(nums);


			string[] strings = ["Alice", "Bob", "Charlie"];

			CollectionHelper.PrintCollection(strings);

			strings.PrintCollection();




			List<string> list = new List<string>() { "Alice", "Bob", "Charlie" };

			list.PrintCollection();



			//LINQ  

			//where 
			//slect
			//OrderBy
			//OrderByDescending
			//ThenBy
			//First()
			//FirstOrDefault()
			// Last()
			// LastOrDefault()
			// Take()
			// skip()
			//Count();



			string[] names = ["Alice", "Bob", "Charlie"];
			names.Count(); //3

			var slected2 = names.Select(el => el.ToUpper());

			var filtred =names.Where(el => el.Length > 4);


			int[] numbers = [100, 20, 30, 40, 50];

			numbers.Sum(); //240
			numbers.Average(); //48


			int pageamoount = 3;
			int pageindex = 1;
			var first3 = numbers.Skip(0).Take(pageamoount);
			var second3 = numbers.Skip(pageindex * pageamoount).Take(pageamoount);
			var third3 = numbers.Skip((pageindex++) * pageamoount).Take(pageamoount);

			var el = numbers.FirstOrDefault(el => el > 40); //0

			var el1 = numbers.First(el => el > 200); //error

			var sorted2 = numbers.OrderBy(el => el).ThenBy(el => el);
			var sorted1 = numbers.OrderByDescending(el => el);


			var selected1 = numbers.Select(el => el / 10);

			var filtere3= numbers.Where(el => el%3==0);

			var filterednumbes = numbers.Where(el => el >40);

			foreach (var item in filterednumbes)
			{
				Console.WriteLine(item);
			}


			var filteredd2 = numbers.Where(el => el % 2 == 0);


			int[] numbers2 = [100, 20, 30, 40, 50];

			numbers2.Where(el => el%5 ==0);
			numbers.Skip(3).Take(2);

		}
	}
}
