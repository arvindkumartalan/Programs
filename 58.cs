using System;
class Mix
{
	public static void M1()
	{
		Console.WriteLine("static method");
	}
	void M2()
	{
		Console.WriteLine("non-static method");
	}
}
class Demo
{
	public static void Main(string [] args)
	{
		Mix.M1();
	}
}