using System;
class Demo
{
	//COMMAND LINE ARGUMENT, RUN TIME INPUT

	public static void Main(string[] a)
	{
		string name = a[0] +" "+ a[1] +" "+ a[2];
		Console.WriteLine("Name is : " +name);
	}
}