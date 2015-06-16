using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades {
	class Program {

		static void GiveBookAName(ref Gradebook book)
		{
			book = new Gradebook();
			book.Name = "The Gradebook";
		}
	

		static void IncrementNumber(out int number)
		{
			number = 42;
			//Console.WriteLine(number + " test");
		}



		static void Main(string[] args)
		{
			string name1 = "Jacob";
			string name2 = "jacob";

			bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
			Console.WriteLine(areEqual);

			Gradebook g1 = new Gradebook();
			Gradebook g2 = g1;

			GiveBookAName(ref g2);
			Console.WriteLine(g2.Name);

			//g1 = new Gradebook();
			//g1.Name = "Jake's Book";

			//Console.WriteLine(g2.Name);
			DateTime d;
			int x1 = 10;
			IncrementNumber(out x1);
			Console.WriteLine(x1);

			//x1 = 100;
			//Console.WriteLine(x2);



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
