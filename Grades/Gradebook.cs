﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades {
	public class Gradebook {

		//public Gradebook()
		//	:this("No Name")
		//{
			
		//}

		public Gradebook(string name = "There is no name")
		{
			Name = name;
			grades = new List<float>();
		}



		public void AddGrade(float grade)
		{
			if (grade >= 0 && grade <= 100)
			{
				grades.Add(grade);
			}
			
		}
		
		public GradeStatistics ComputeStatistics() {

			GradeStatistics stats = new GradeStatistics();
			

			float sum = 0f;
			foreach (float grade in grades)
			{
				stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
				stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
				sum += grade;
			}


			stats.AverageGrade = sum/grades.Count;

			return stats;
		}

		//private string _name;

		private string _name;


		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (_name != value)
				{
					var oldValue = _name;
					_name = value;
					if (NameChanged != null)
					{
						NameChanged(oldValue, value);
					}
				
				}
				
			}
		}

		public NamedChangeDelegate NameChanged;
		private List<float> grades;

		
	}
}
