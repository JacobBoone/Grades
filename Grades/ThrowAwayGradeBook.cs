using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades {
	public class ThrowAwayGradeBook : Gradebook
	{
		public ThrowAwayGradeBook(string name)
			:base(name)
		{
			Console.WriteLine("throwaway ctor");
		}

		public override GradeStatistics ComputeStatistics()
		{
			Console.WriteLine("Throwaway computestats method");
			float lowest = float.MaxValue;
			foreach (float grade in _grades)
			{
				lowest = Math.Min(lowest, grade);
			}
			_grades.Remove(lowest);
			return base.ComputeStatistics();
		}
			
	}
}
