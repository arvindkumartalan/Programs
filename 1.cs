using System;
class demo
{
	public static void Main(string [] args)
	{
		/*
		11111
		11111
		11111
		11111
		11111
		*/
		int ctr = 0;
		while(ctr<5)
		{
			int ptr = 0;
			while(ptr<5)
			{
				Console.Write(1);
				ptr++;
			}
			Console.WriteLine();
			ctr++;
		}
	}	
}