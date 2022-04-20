using System;
class demo
{
	public static void Main(string [] args)
	{
		/*
		12345
		12345
		12345
		12345
		12345
		*/
		int ctr = 1;
		while(ctr<=5)
		{
			int ptr = 1;
			while(ptr<=5)
			{
				Console.Write(ptr);
				ptr++;
			}
			Console.WriteLine();
			ctr++;
		}
	}	
}