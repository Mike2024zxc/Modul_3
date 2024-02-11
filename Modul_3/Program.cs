using System;

namespace Modul_3
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

			var color = Console.ReadLine();

			switch (color)
			{
				case "red":
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is red!");
					break;

				case "green":
					Console.BackgroundColor = ConsoleColor.Green;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is green!");
					break;

				default:
					Console.BackgroundColor = ConsoleColor.Cyan;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is cyan!");
					break;
			}



			/*
			//var name = "Jane";
			Console.WriteLine("What is your name?");
			var name = Console.ReadLine();

			var age = checked((byte)int.Parse(Console.ReadLine()));
			Console.WriteLine("Your name is {0} and age is {1} ", name, age);

			Console.Write("What is your favorite day of week? ");

			var day = (DayOfWeek)int.Parse(Console.ReadLine());
			Console.WriteLine("Your favorite day is {0}", day);


			/*string MyName = "Jane";
			byte MyAge = 27;
			bool HaveIApet = true;
			double MyShoeSize = 37.5;

			Console.WriteLine("My name is " + MyName);
			Console.WriteLine("MyAge " + MyAge);
			Console.WriteLine("Do I have a pet? " + HaveIApet);
			Console.WriteLine("My shoe size is " + MyShoeSize);
			Console.WriteLine("\u0040");
			Console.WriteLine("\u0023");


			DaysOfWeek MyFavoriteDay;

			MyFavoriteDay = DaysOfWeek.Friday;

			Console.WriteLine(MyFavoriteDay);
			Console.ReadKey();*/

			//Console.WriteLine("\tПривет,\n мир!");
			//Console.ReadKey();

			//int counter = 10;
			//Console.WriteLine("Value : {0} Increment: {1}", counter, counter++);*//
		} 
			//enum DaysOfWeek : byte
		//{
			//Tuesday,
			//Monday,
			//Wednesday,
			//Friday
		//}
	}
    }

