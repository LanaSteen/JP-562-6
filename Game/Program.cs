namespace Game
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");


			Enemy andria	= new Enemy();
			andria.Name = "Andria";
			andria.Sthrength = 20;

			Enemy umidi = new Enemy();
			umidi.Name = "Umidi";
			umidi.Sthrength = 20;


			andria.CompareTo(umidi);  


	

		}
	}
}

 //   Sprite 
	//Enemy
	//Player
	//Food
	//Boss


