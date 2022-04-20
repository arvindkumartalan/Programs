using System;
class demo
{
	public static void Main(string [] args)
	{
		/*
		*
		**
		***
		****
		*****
		*/
		int ctr = 0;
		while(ctr<=5)
		{
			int ptr = 0;
			while(ptr<=ctr)
			{
				Console.Write("*");
				ptr++;
			}
			Console.WriteLine();
			ctr++;
		}
	}	
}