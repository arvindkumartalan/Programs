using System;
class demo
{
	public static void Main(string [] args)
	{
		/*
		ABCDE
		ABCDE
		ABCDE
		ABCDE
		ABCDE
		*/
		int ctr = 0;
		while(ctr<5)
		{
			char A = 'A';
			int ptr = 0;
			while(ptr<5)
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