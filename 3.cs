using System;
class demo
{
	public static void Main(string [] args)
	{
		/*
		11111
		22222
		33333
		44444
		55555
		*/
		int ctr = 1;
		while(ctr<=5)
		{
			int ptr = 1;
			while(ptr<=5)
			{
				Console.Write(ctr);
				ptr++;
			}
			Console.WriteLine();
			ctr++;
		}
	}	
}