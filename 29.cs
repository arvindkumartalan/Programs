using System;
class Demo
{
	public static void Main(string[] a)
	{
		//convert lower case to upper case
		Console.Write("Enter a name : ");
		string str=Console.ReadLine();
		char []arr=str.ToCharArray();
		foreach(char array in arr)
		Console.Write(char.ToUpper(array));
		//convert upper case to lower case
		Console.WriteLine();
		foreach(char array in arr)
		Console.Write(char.ToLower(array));
	}
}