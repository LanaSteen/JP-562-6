namespace Lesson5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.InputEncoding = System.Text.Encoding.UTF8;

			//			შექმენით პროდუქტის კლასი.
			//			მოიფიქრეთ 5 ფროფერთი.
			//შემდეგ შექმენით ამ პროდუქტების ლისტი.
			//სიაში დაამატეთ 3 ახალი პროდუქტი for ის და Console.Readline ის გამოყენებით.



			//List<Product> products = new List<Product>();


			//			public string Name { get; set; }
			//public decimal Price { get; set; }
			//public Category Category { get; set; }

			//public List<Color> Color { get; set; }

			//public int Amount { get; set; }


			//for (int i = 0; i < 3; i++)
			//{
			//	Product product = new();
			//	Console.WriteLine("პროდუქტის სახელი");
			//	product.Name = Console.ReadLine();
			//	//Console.WriteLine("პროდუქტის ფასი");
			//	//product.Price= decimal.Parse(Console.ReadLine())*1m;
			//	product.Category = Category.Tablet;

			//	product.Color.Add(Color.Red);
			//	Console.WriteLine("პროდუქტის რაოდენობა");
			//	product.Amount = int.Parse( Console.ReadLine());

			//   products.Add(product);

			//}


			//foreach (var item in products)
			//{
			//	Console.Write(item);
			//	foreach (var item1 in item.Color)
			//	{
			//		Console.Write(item1);
			//	}

			//	Console.WriteLine();
			//}





			// კოლექციები
			// მასივი , ლისტი

			//HashSet<int> numbers = new HashSet<int>();

			//numbers.Add(1);
			//numbers.Add(1);
			//numbers.Add(1);
			//numbers.Add(2);

			//foreach (var item in numbers)
			//{
			//	Console.WriteLine(item);
			//}



			//List<string> countries = new List<string>() {"Georgia" , "Georgia", "Itali" };

			//var newCountries = countries.ToHashSet();

			//foreach (var item in newCountries)
			//{
			//	Console.WriteLine(item);
			//}


			////FIFO
			//Queue<string> queue = new Queue<string>();
			//queue.Enqueue("nino");
			//queue.Enqueue("Tatuli");


			////Console.WriteLine(queue.Peek());

			//queue.Dequeue();
			//Console.WriteLine(queue.Peek());

			//Console.WriteLine();


			////LIFO

			//Stack<int> numbers = new Stack<int>();

			//numbers.Push(100);
			//numbers.Push(200);

			//Console.WriteLine(numbers.Peek());  // 200
			//numbers.Pop();

			//Console.WriteLine(numbers.Peek());  // 200
			/////  რიგი

			//int x = 5;
			//int[] arr = [50, 30, 20];


			//Product product = new Product();
			//product.Name = "sfdfgfgf";


			Console.WriteLine(Factorial(5));



		}




		//public static void Print()
		//{
		//	Print();
		//}





		//    2 3  
		//2 * 2 2
		//2 * 2 1

		public static int Pow(int num, int pow)   // 2,3
		{
			if(pow == 1)
			{
				return num;
			}

			return num * Pow(num, pow - 1);
		}


		//5 * 4 * 3 * 2 * 1


		public static int Factorial(int num) 
		{
			if(num == 1)
			{
				return 1;
			}

			return num * Factorial(num - 1);


		}

	}
}
