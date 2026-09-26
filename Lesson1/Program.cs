namespace Lesson1
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region if foor


			//Console.WriteLine("Hello, World!");

			//Console.WriteLine("Hello, World!");

			//Console.Write("Enter name - ");

			//string name = Console.ReadLine();

			//Console.WriteLine("enter age");


			//Int64 age = Convert.ToInt64(Console.ReadLine());

			//Console.WriteLine(int.MinValue);
			//Console.WriteLine(int.MaxValue);


			//Console.WriteLine('a'); //char



			//Console.WriteLine("enter your age");
			//byte age = Convert.ToByte(Console.ReadLine());

			//byte age1 = byte.Parse(Console.ReadLine());

			//false                                             0
			//bool isValid = byte.TryParse(Console.ReadLine(), out byte age);



			//მომხმარებელმა შემოიყვანოს ასაკი  და შემოიყვანოს სიმბოლო 'A'
			//	ასაკი თუ მეტია 18 ზე და სიმბოლო 'A' არის შემოყვანილი 
			//	მაშინ დაბეჭდოს "you are adult" 
			//	წინააღმდეგ შემთხვევაში დაბეჭდოს "you are not adult"





			//method  vs function


			//alert
			//consoel.log



			//10




			//for loop
			//int age1 = 50;

			//while (age1 > 100) 
			//{
			//}


			//do
			//{
			//	Console.WriteLine("sss");
			//}
			//while (age1 > 100);



			////[50,60,30]
			////
			//int[] numbers = [20,30,60];      // new int[3] { 50, 60, 30 };

			//int[] numbers2 = {20, 30, 60};


			//int[] scores = new int[3];   //  [0,0,0]
			//scores[0] = 50;

			//scores[1] = 60;

			//scores[2] = 30;

			//string[] names = new string[4]; // [null,null,null,null]



			//string[] names2 = [ "John", "Jane", "Bob", "Alice" ];


			//for (int i = 0; i < names2.Length; i++)
			//{
			//	for (int j = 0; j < names2[i].Length; j++)
			//	{
			//		Console.WriteLine(names2[i][j]);
			//	}
			//}


			#endregion





			// local function


			//void printName(string name)
			//{
			//	Console.WriteLine(name);
			//}

			////string rame = printName("rame");





			//string getName(string name)
			//{
			//	return name.ToUpper();
			//}


			//string upperName = getName("rame");

			//Console.WriteLine(upperName + " gamarjoba");




			//int getSum(int num1, int num2)
			//{
			//	return num1 + num2;
			//}

			//int sum = getSum(9, 5);

			//Console.WriteLine(sum);



			//  Print();

			//Console.WriteLine();




			//User user1 = new User("rame", 20, "12345678");

			//user1.Name = "rame2";

			//user1.Age = 20;

			//user1.Pass = Console.ReadLine();

			//user1.Colors =  [ "red", "green", "blue" ];

			//Person pers = new Person();
			//pers.Colors = ["red", "green", "blue"];




			Product product1 = new Product();

			product1.Name = "Product1"; 
			product1.Price = 10.99m;
			product1.Brand = "Brand1";
			product1.Colors = [Color.Red, Color.Green, Color.Blue];



			Product product2 = new Product();

			product2.Name = "Product2";
			product2.Price = 10.99m;
			product2.Brand = "Brand1";
			product2.Colors = [Color.Red, Color.Green, Color.Blue];

			Console.WriteLine(product2);
			//product1.DisplayInfo();


			//product2.DisplayInfo();


			float x = 10.5f;
			double y = 20.5;
			decimal z = 30.5m;


			DateTime now = DateTime.Now;

			Console.WriteLine(now.Year);


		}

	
	

		static void Print()
		{
			Console.WriteLine("hi");
		}
	  
	
	
	
	}
}


//  სახელი

// ფასი   --   უარყოფითი არ შეიძლება

// ბრენდი
