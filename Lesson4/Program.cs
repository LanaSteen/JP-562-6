using Lesson4.Library;

namespace Lesson4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");


			//GameCharacter personaji = new();



			//Warrior warrior = new Warrior();
			//warrior.Name = "Conan";
			//warrior.DisplayInfo();
			//warrior.Attack();
			//warrior.Defend();

			//Mage mage = new Mage();
			//mage.Name = "Gandalf";
			//mage.DisplayInfo();
			//mage.Attack();
			//mage.Defend();



			//Archer archer = new Archer();
			//archer.Name = "Legolas";
			//archer.DisplayInfo();
			//archer.Attack();
			//archer.Defend();



			//Book book1 = new Book();
			//book1.Title = "The Lord of the Rings: The Fellowship of the Ring";
			//book1.Author = "J.R.R. Tolkien";


			//Book book2 = new Book();
			//book2.Title = "The Lord of the Rings: The Two Towers";
			//book2.Author = "J.R.R. Tolkien";


			//Library.Library library = new Library.Library();
			//library.Books = [book1, book2];

			//int[] num= [10];



			//List<int> numbers = new() {10,15,20};
			//List<int> numbers = new();

			//numbers.Add(10);
			//numbers.Add(15);
			//numbers.Add(20);
			////{10,15,20 } 


			//List<string> names = new() { "John", "Jane", "Bob" };

			//names.Add("Alice");



			//List<Book> books = new() { book1, book2 };

			//Book book3 = new Book();
			//books.Add(book3);

			////[]

			//books.AddRange();


			//for (int i = 0; i < books.Count; i++)
			//{
			//	Console.WriteLine(books[i].Title);
			//}


			//foreach (var item in books)
			//{
			//	Console.WriteLine(item.Title);
			//}

			//library.Books.Add



			//List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
			//List<int> ints2 = new List<int>() {10,11,12};
			//int[] numbers = {20, 65, 32};

			////{ 1, 2, 3, 4, 5 , 10 , 11 , 12, 20, 65, 32};

			//ints.AddRange(ints2);
			//ints.AddRange(numbers);

			//foreach (var item in ints)
			//{
			//	Console.WriteLine(item);
			//}


			List<int> ints = new List<int>() { 1, 2, 3, 4, 3, 5 };
			ints.Remove(3); //elemnt Removes the first occurrence of 3

			ints.Contains(3); //returns true if 3 is in the list, false otherwise


			//foreach (var item in ints)
			//{
			//	if (ints.Contains(3))
			//	{
			//			ints.Remove(3);
			//	}
			//}



			//while (ints.Contains(3))
			//{
			//	ints.Remove(3);
			//}


			//foreach (var item in ints)
			//{
			//	Console.WriteLine(item);
			//}


			//var index= ints.IndexOf(4); //returns the index of the first occurrence of 4, or -1 if not found

			//ints.RemoveAt(index);

		 //   ints.Insert(index, 99); //inserts 99 at index 2



			//List<string> names = new() {"John", "Jane", "Andria", "Bob" };


			//var index2 = names.IndexOf("Andria");

			//names.RemoveAt(index2);
			//names.Insert(index2, "SpiderMan");




			//names.Clear();

			//int[] numbers = { 1, 2, 3, 4, 5 };


			//Array.Reverse(numbers); //reverses the array in place

			//var list = numbers.ToList();
			//list.Add(6);

			//int[]  numbers2 = list.ToArray();


			//list.Reverse();



			//Console.WriteLine(list.Count);  // 6
			//Console.WriteLine(list.Capacity); // 6 





			List<int> numbers = new List<int>();
			numbers.Add(6);
			numbers.Add(7);
			numbers.Add(8);
			numbers.Add(9);
			numbers.Add(10);
			numbers.Add(7);
			numbers.Add(8);
			numbers.Add(9);
			numbers.Add(10);
			Console.WriteLine(numbers.Count); // 0
			Console.WriteLine(numbers.Capacity); // 0

			//linq
		}
	}
}


//შექმენით ბიბლიოთეკა გყვათ მომხმარებელი, მენეჯერი, წიგნი.
	
	
	
	
	
	