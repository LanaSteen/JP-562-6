namespace Lesson10
{
	internal class Program
	{
		static void Main(string[] args)
		{



			#region linq
			//int[] prices = [50, 30, 60, 20, 78];

			//var numbers = prices.Where(x => x > 50);

			//var last = prices.Last(x=> x %2!=0);
			//var last2 = prices.LastOrDefault(x => x % 2 != 0);



			//var sorted = prices.OrderBy(x => x).ThenBy();

			//var seletced = prices.Select(x => x.ToString());


			//Student student = new Student();
			//student.Grade = 89;
			//student.Age = 23;
			//student.Name = "Ayşe";



			//Student student2= new Student();
			//student2.Grade = 78;
			//student2.Age = 24;
			//student2.Name = "Fatma";


			//Student student3 = new Student();
			//student3.Grade = 60;
			//student3.Age = 24;
			//student3.Name = "Mehmet";


			//Student[] students = new Student[] { student, student2, student3 };
			//var sortedStudents = students.OrderBy(x => x.Age).ThenBy(x => x.Grade); //Ayşe   Mehmet  Fatma

			#endregion


			string path = "C:\\Users\\l4nst\\Desktop\\JP-562-6\\Lesson10\\Data\\users.txt";
			MenuHelper.ShowMenu(path);
		}
	}
}
