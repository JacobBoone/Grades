﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.IO;

namespace Grades 
{
	class Program 
	{

		//static void GiveBookAName(ref Gradebook book)
		//{
		//	book = new Gradebook();
		//	book.Name = "The Gradebook";
		//}
	

		//static void IncrementNumber(out int number)
		//{
		//	number = 42;
		//	//Console.WriteLine(number + " test");
		//}

		static void Main(string[] args)
		{

			IGradeTracker book = CreateGradeBook();

			try
			{
				using (FileStream stream = File.Open("grades.txt", FileMode.Open))
				using (StreamReader reader = new StreamReader(stream))
				{
					string line = reader.ReadLine();
					while (line != null) {
						float grade = float.Parse(line);
						book.AddGrade(grade);
						line = reader.ReadLine();
					}
				}
				

			}
			catch (FileNotFoundException ex)
			{

				Console.WriteLine("Could not locate the file");
				return;
			}
			catch (UnauthorizedAccessException ex)
			{
				Console.WriteLine("No Access");
				return;
			}
			//finally
			//{
			//	if (reader != null)
			//	{
			//		reader.Close();
			//	}
			//	if (stream != null)
			//	{
			//		stream.Close();
			//	}
				
			//}

			foreach (float grade in book)
			{
				Console.WriteLine(grade);
			}

			try
			{
				//Console.WriteLine("Please enter a name for the book");
				//book.Name = Console.ReadLine();
			}
			catch (ArgumentException)
			{
				Console.WriteLine("Invalid name");
			}

			GradeStatistics stats = book.ComputeStatistics();

			////book.Name = "";
			//book.NameChanged += OnNameChanged;
			//book.NameChanged += OnNameChanged;
			//book.NameChanged += OnNameChanged2;
			//book.NameChanged -= OnNameChanged;


			//book.Name = "John's Book";
			//WriteNames(book.Name);

		

			Console.WriteLine("Average Grade is " + stats.AverageGrade);
			Console.WriteLine("Lowest Grade is " + stats.LowestGrade);
			Console.WriteLine("Highest Grade is " + stats.HighestGrade);

			Console.WriteLine("{0} {1}", stats.LetterGrade, stats.Description);

		
			//SpeechSynthesizer synth = new SpeechSynthesizer();
			//synth.Speak("Hello, World");

			//Arrays();

			//Immutable();

			//PassByValueAndRef();

			//g1 = new Gradebook();
			//g1.Name = "Jake's Book";

			//Console.WriteLine(g2.Name);

			//x1 = 100;
			//Console.WriteLine(x2);
		}

		private static IGradeTracker CreateGradeBook()
		{
			IGradeTracker book = new ThrowAwayGradeBook("Jacob's Book");
			return book;
		}

		private static void OnNameChanged2(object sender, NameChangedEventArgs args) {
			Console.WriteLine("***");
		}

		private static void OnNameChanged(object sender, NameChangedEventArgs args) {
			Console.WriteLine("Name Changed from {0} to {1}", args.OldValue, args.NewValue);
		}

	

		private static void WriteBytes(int value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			WriteByteArray(bytes);
		}

		private static void WriteBytes(float value) 
		{
			byte[] bytes = BitConverter.GetBytes(value);
			WriteByteArray(bytes);
		}

		private static void WriteByteArray(byte[] bytes) 
		{
			foreach (byte b in bytes) 
			{
				Console.Write(" 0x{0:X}", b);
			}
			Console.WriteLine();
		}
		private static void WriteNames(params string[] names) 
		{
			foreach (string name in names) {
				Console.WriteLine(name);
			}
		}



	//	private static void Arrays()
	//	{
	//		float[] grades;

	//		grades = new float[3];

	//		AddGrades(grades);

	//		foreach (float grade in grades)
	//		{
	//			Console.WriteLine(grade);
	//		}
			
	//	}

	//	private static void AddGrades(float[] grades) {
	//		if (grades.Length >= 3)
	//		{
	//			grades[0] = 91f;
	//			grades[1] = 89.1f;
	//			grades[2] = 75f;
	//		}
			
	//	}

	//	private static void Immutable()
	//	{
	//		string name = " Jacob ";
	//		name = name.Trim();

	//		DateTime date =  new DateTime(2014, 1, 1);
	//		date = date.AddHours(25);

	//		Console.WriteLine(name);
	//		Console.WriteLine(date);
	//	}

	//	private static void PassByValueAndRef()
	//	{
	//		Gradebook g1 = new Gradebook();
	//		Gradebook g2 = g1;

	//		GiveBookAName(ref g2);
	//		Console.WriteLine(g2.Name);

	//		int x1 = 10;
	//		IncrementNumber(out x1);
	//		Console.WriteLine(x1);
	//	}
	}
}
