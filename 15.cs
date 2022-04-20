using System;
class demo
{
	public static void Main(string [] args)
	{
			char x = 'a';
			char z = 'A';
			char y ;
			string str;
			Console.Write("Enter any Character : ");
			str = Console.ReadLine();
			y = str[0];
			while(y==x)
			{
					Console.Write("First Letter is small alphabet");
					break;
			}x++;
			while(y==z)
			{
					Console.Write("First Letter is capital alphabet");
					break;
			}z++;
			
	}
}