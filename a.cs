using System;
class demo
{
	public static void Main(string [] args)
	{
		/*
		AAAAA
		AAAAA
		AAAAA
		AAAAA
		AAAAA
		*/
		int ctr = 0;
		while(ctr<5)
		{
			int ptr = 0;
			while(ptr<5)
			{
				Console.Write("A");
				ptr++;
			}
			Console.WriteLine();
			ctr++;
		}
	}	
}