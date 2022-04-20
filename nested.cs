using System;
class Demo
{
	public static void Main(string [] a)
	{
		/*
		******
		 *****
		  ****
		   ***
		    **
			 *
		   
		*/
		int x=0;
		int y;
		while(x<=5)
		{
			y = 1;
			while(y<=x)
			{
				Console.Write(" ");
				y++;
			}
			int z = x;
			while (z<=5)
			{
				Console.Write("*");
				z++;
			}
			Console.WriteLine();
			x++;
		}
		
	}
}