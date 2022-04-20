using System;
class demo
{
	//PRINT CHAR ARRAY VALUES
	public static void Main(string[]a)
	{
		char []arr;         //declare
		arr = new char[5];   //memory allocation
		arr[0] = (char)(100);      //again declare
		arr[1] = (char)(122); 
		arr[2] = (char)(67); 
		arr[3] = (char)(76); 
		arr[4] = (char)(72); 
		Console.WriteLine(arr[0]);
		Console.WriteLine(arr[1]);
		Console.WriteLine(arr[2]);
		Console.WriteLine(arr[3]);
		Console.WriteLine(arr[4]);
		
	}
}