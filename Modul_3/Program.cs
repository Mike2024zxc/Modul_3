﻿using System;

namespace Modul_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			string MyName = "Jane";
			byte MyAge = 27;
			bool HaveIApet = true;
			double MyShoeSize = 37.5;

			Console.WriteLine("My name is " + MyName);
			Console.WriteLine("MyAge " + MyAge);
			Console.WriteLine("Do I have a pet? " + HaveIApet);
			Console.WriteLine("My shoe size is " + MyShoeSize);
			Console.WriteLine("\u0040");
			Console.WriteLine("\u0023");
			Console.ReadKey();
		}
    }
}
