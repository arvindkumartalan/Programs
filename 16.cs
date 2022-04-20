using System;
class demo
{
	//TO FIND FIRST LETTER IS SMALL OR CAPITAL
	public static void Main(string [] args)
	{
			char x ;
			char z ;
			//int a ;
			char y ;
			string str;
			Console.Write("Enter any Character : ");
			str = Console.ReadLine();
			y = str[0];
			for(x='a'; x<=y; x++)
			{
				if(x==y)
					Console.WriteLine("FIrst letter is Small character");
			}
			for(z='A'; z<=y; z++)
			{
				if(z==y)
					Console.WriteLine("FIrst letter is capital character");
			}
			
	}
}