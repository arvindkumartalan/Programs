using System;
class demo
{
	//TO FIND ENTERED NUMBER IS EVEN OR ODD
	public static void Main(string [] args)
	{
		int ctr = 1;
		int num;
		//int sum = 0;
		while(ctr<=5)
		{
			Console.Write("Enter The ");
			Console.Write(ctr);
			Console.Write(" Number : ");
			num = Convert.ToInt32(Console.ReadLine());
			if(num%2==0)
				Console.WriteLine("Number Is Even");
			else
				Console.WriteLine("Number Is Odd");
			ctr++;
			//num++;
		}
		Console.WriteLine();
	}
}