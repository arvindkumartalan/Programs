using System;
class demo
{
	//TO CALCULATE SUM AND AVERAGE OF ANY NUMBERS
	public static void Main(string [] args)
	{
		int ctr = 0;
		int num = 0;
		int sum = 0;
		while(ctr<=5)
		{
			Console.Write("Enter The Number : " );
			num = Convert.ToInt32(Console.ReadLine());
			sum = num+sum;
			ctr++;
		}
		Console.WriteLine("Total Result is : " +sum);
		float avg = sum/ctr;
		Console.WriteLine("Average is : " +avg);
	}
}