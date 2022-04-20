using System;
class demo
{
	public static void Main(string [] args)
	{
		/*
		AAAAA
		BBBBB
		CCCCC
		DDDDD
		EEEEE
		*/
		char A = 'A';
		int ctr = 0;
		while(ctr<5)
		{
			int ptr = 0;
			while(ptr<5)
			{
				
				Console.Write(A);
				ptr++;
			}
			A++;
			Console.WriteLine();
			ctr++;
		}
	}	
}