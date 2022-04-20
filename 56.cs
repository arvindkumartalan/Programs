using System;
class Demo
{
	/*
	11111
	1111
	111
	11
	1
	*/
	public static void Main(string [] args)
	{
		int i;
		int j;
		for(i=0; i<5; i++)
		{
			for(j=5; j>i ; j--)
			{
				Console.Write(1);
			}
			Console.WriteLine();
		}
	}
}
