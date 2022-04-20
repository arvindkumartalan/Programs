using System;
class Demo
{
	/*
	 ABCDE
	 ABCD
	 ABC
	 AB
	 A
	*/
	public static void Main(string [] args)
	{
		int i;
		int j;
		for(i=0; i<5; i++)
		{
			char c = 'A';
			for(j=5; j>i ; j--)
			{
				Console.Write(c);
				c++;
			}
			Console.WriteLine();
		}
	}
}
