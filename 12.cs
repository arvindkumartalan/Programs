using System;
class demo
{
	//TO ADD ENTERED NUMBERS
	public static void Main(string [] args)
	{
		int ctr = 1;
		int num = 0;
		int sum = 0;
		while(ctr<=5)
		{
			Console.Write("Enter The ");
			Console.Write(ctr);
			Console.Write(" Number : ");
			num = Convert.ToInt32(Console.ReadLine());
			sum = num+sum;
			ctr++;
		}
		Console.WriteLine("Total Result is : " +sum);
	}
}