using System;
class demo
{
	public static void Main(string [] args)
	{
		/*
		1
		12
		123
		1234
		12345
		*/
		int ctr = 1;
		while(ctr<=5)
		{
			int ptr = 1;
			while(ptr<=ctr)
			{
				Console.Write(ptr);
				ptr++;
			}
			Console.WriteLine();
			ctr++;
		}
	}	
}