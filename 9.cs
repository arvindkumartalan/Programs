using System;
class demo
{
	public static void Main(string [] args)
	{
		/*
		A
		AA
		AAA
		AAAA
		AAAAA
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
				//A++;
			}
			Console.WriteLine();
			ctr++;
			
		}
	}	
}