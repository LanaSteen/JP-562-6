using Lesson3.FilmStudio;

namespace Lesson3
{
	internal class Program
	{
		static void Main(string[] args)
		{



			Student student = new();
			student.Name = "dsdgfhgjj,";


			Student student2 = new();
			student2.Name = "dsdgfhgjj,";

			student2.Walk(); /// 




			//Person person = new(); /// 


			Mandaturi mandaturi = new();



			Film film = new();

			Actor actor = new("John");
			Actor actor2 = new("Jane");

			film.Actors = [actor, actor2];

		}
	}
}
