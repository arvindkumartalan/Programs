using System;
class demo
{
	public static void Main(string [] args)
	{
		/*
		A
		AB
		ABC
		ABCD
		ABCDE
		*/
		int ctr = 1;
		while(ctr<=5)
		{
			char A = 'A';
			int ptr = 1;
			while(ptr<=ctr)
			{
				Console.Write(A);
				ptr++;
				A++;
			}
			Console.WriteLine();
			ctr++;
			
		}
	}	
}