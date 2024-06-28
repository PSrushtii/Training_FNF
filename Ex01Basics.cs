using System;
namespace SampleConApp
{
	class SampleExample{
		static void display()
		{
			Console.WriteLine("Hello World");
			Console.WriteLine("My name is Srushti Patil");
			Console.WriteLine("I am from Sidnal");
			Console.WriteLine("I work on .NET");
		}

		static void inputExample()
		{
			Console.WriteLine("Enter your name");
			string name=Console.ReadLine();

			Console.WriteLine("Enter Your phone number");
			string phone =Console.ReadLine();

			Console.WriteLine("Enter your age");
			int age=int.Parse(Console.ReadLine());

			Console.WriteLine("The name is + {0}  with contacting {1} and ages {2}", name, phone,age);
			Console.WriteLine("Ms. {0}'s age will be {1} after 15 years",name, age+15);

		}
		
		static void Main(){
			//display();
			inputExample();
		}
	}
}		