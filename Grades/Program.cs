using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades {
	class Program {
		static void Main(string[] args)
		{
			Gradebook book = new Gradebook();
			book.AddGrade(91f);
			book.AddGrade(89.1f);
			book.AddGrade(75f);

			GradeStatistics stats= book.ComputerStatistics();
			Console.WriteLine("Average Grade is " + stats.AverageGrade);
			Console.WriteLine("Lowest Grade is " + stats.LowestGrade);
			Console.WriteLine("Highest Grade is " + stats.HighestGrade);
			
			

		}
	}
}
