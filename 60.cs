using System;
namespace ConsoleApp1
{

	class Demo
	{
		void M3()
		{
			Console.WriteLine("non-static in main method");
			Mixture m = new Mixture();



		}
		protected static void Main(string[] args)
		{
			Demo d = new Demo();
			d.M3();
		}
	}
}