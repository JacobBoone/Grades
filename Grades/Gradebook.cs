using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades {
	public class Gradebook : GradeTracker
	{
		public Gradebook(string name = "There is no name")
		{
			Console.WriteLine("gradebook ctor");
			Name = name;
			_grades = new List<float>();
		}

		public override IEnumerator GetEnumerator()
		{
			return _grades.GetEnumerator();
		}

		public override void DoSomething()
		{

		}

		public override void AddGrade(float grade)
		{
			if (grade >= 0 && grade <= 100)
			{
				_grades.Add(grade);
			}

		}


		public override GradeStatistics ComputeStatistics()
		{

			Console.WriteLine("regular computestats method in gradebook");
			GradeStatistics stats = new GradeStatistics();


			float sum = 0f;
			foreach (float grade in _grades)
			{
				stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
				stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
				sum += grade;
			}


			stats.AverageGrade = sum/_grades.Count;

			return stats;
		}

		public override void WriteGrades(TextWriter textWriter)
		{
			textWriter.WriteLine("Grades: ");
			for (int i = 0; i < _grades.Count; i++)
			{
				textWriter.WriteLine(_grades[i]);
			}
			//int i = 0;
			//while (i < _grades.Count) {
			//	textWriter.WriteLine(_grades[i]);

			//	i++;
			//}


			textWriter.WriteLine("*********");
		}

		//private string _name;




		protected List<float> _grades;


	}
}
