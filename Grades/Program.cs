using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades {
	class Program {
		static void Main(string[] args)
		{

			Gradebook g1 = new Gradebook();
			Gradebook g2 = g1;

			g1 = new Gradebook();
			g1.Name = "Jake's Book";

			Console.WriteLine(g2.Name);





			//Gradebook book = new Gradebook();
			//book.AddGrade(91f);
			//book.AddGrade(89.1f);
			//book.AddGrade(75f);

			//GradeStatistics stats= book.ComputerStatistics();
			//Console.WriteLine("Average Grade is " + stats.AverageGrade);
			//Console.WriteLine("Lowest Grade is " + stats.LowestGrade);
			//Console.WriteLine("Highest Grade is " + stats.HighestGrade);



		}
	}
}
