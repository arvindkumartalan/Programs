using System;
class demo
{
	//TO FIND ENTERED NUMBER IS VOWEL OR NOT
	public static void Main(string [] args)
	{
			char y ;
			string str;
			Console.Write("Enter any Character : ");
			str = Console.ReadLine();
			y = str[0];
			switch(y)
			{
				case 'a':
				Console.WriteLine("Vowel Hai");
				break;
				case 'e':
				Console.WriteLine("Vowel Hai");
				break;
				case 'i':
				Console.WriteLine("Vowel Hai");
				break;
				case 'o':
				Console.WriteLine("Vowel Hai");
				break;
				case 'u':
				Console.WriteLine("Vowel Hai");
				break;
				case 'A':
				Console.WriteLine("Vowel Hai");
				break;
				case 'E':
				Console.WriteLine("Vowel Hai");
				break;
				case 'I':
				Console.WriteLine("Vowel Hai");
				break;
				case 'O':
				Console.WriteLine("Vowel Hai");
				break;
				case 'U':
				Console.WriteLine("Vowel Hai");
				break;
				default:
				Console.WriteLine("Other hai");
				break;
				
			}

	}
}