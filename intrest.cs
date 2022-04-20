using System;
class demo
{
	public static void Main(string [] args)
	{
		int principle;
		int rate;
		int time;
		int intrest;
		while(ctr<=5)
		{
			Console.Write("Enter The Principle : " );
			Principle = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter The rate : " );
			rate = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter The time in Months : " );
			time = Convert.ToInt32(Console.ReadLine());
			intrest = principle*rate*time/100;
			Console.WriteLine("Total Intrest is : " +intrest);
			
		}
		
	}
}