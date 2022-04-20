using System;
class demo
{
	public static void Main(string [] args)
	{
		/*
		A
		BB
		CCC
		DDDD
		EEEEE
		*/
		char A = 'A';
		int ctr = 1;
		while(ctr<=5)
		{
			int ptr = 1;
			while(ptr<=ctr)
			{
				Console.Write(A);
				ptr++;
			}
			Console.WriteLine();
			ctr++;
			A++;
		}
	}	
}