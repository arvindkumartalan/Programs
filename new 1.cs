using System;
class Demo
{
	public static void Main()
	{
		Console.write("Enter First Number");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.write("Enter Second Number");
		int num2 = Convert.ToInt32(Console.ReadLine());
		int num3 = num1+num2;
		Console.WriteLine(num3);
	}
}