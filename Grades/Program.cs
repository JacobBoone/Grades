﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

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
			SpeechSynthesizer synth = new SpeechSynthesizer();
			synth.Speak("Hello, World");

			Arrays();

			//Immutable();

			//PassByValueAndRef();

			//g1 = new Gradebook();
			//g1.Name = "Jake's Book";

			//Console.WriteLine(g2.Name);

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

		private static void Arrays()
		{
			float[] grades;

			grades = new float[3];

			AddGrades(grades);

			foreach (float grade in grades)
			{
				Console.WriteLine(grade);
			}
			
		}

		private static void AddGrades(float[] grades) {
			if (grades.Length >= 3)
			{
				grades[0] = 91f;
				grades[1] = 89.1f;
				grades[2] = 75f;
			}
			
		}

		private static void Immutable()
		{
			string name = " Jacob ";
			name = name.Trim();

			DateTime date =  new DateTime(2014, 1, 1);
			date = date.AddHours(25);

			Console.WriteLine(name);
			Console.WriteLine(date);
		}

		private static void PassByValueAndRef()
		{
			Gradebook g1 = new Gradebook();
			Gradebook g2 = g1;

			GiveBookAName(ref g2);
			Console.WriteLine(g2.Name);

			int x1 = 10;
			IncrementNumber(out x1);
			Console.WriteLine(x1);
		}
	}
}
