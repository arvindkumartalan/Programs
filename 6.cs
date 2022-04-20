using System;
class demo
{
	/*
	1
	22
	333
	4444
	55555
	*/
	public static void Main(string [] args)
	{
		int ctr = 1;
		while(ctr<=5)
		{
			int ptr = 1;
			while(ptr<=ctr)
			{
				Console.Write(ctr);
				ptr++;
			}
			Console.WriteLine();
			ctr++;
		}
	}	
}