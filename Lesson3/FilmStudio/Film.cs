using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3.FilmStudio
{
	internal class Film
	{

		public string Title { get; set; }
		public int ReleaseYear { get; set; }

		public Actor[] Actors { get; set; }
		public Director[] Director { get; set; }
		public Producer[] Producer { get; set; }
	}
}
