using System;
class demo
{
	//PRINT ARRAY VALUES
	public static void Main(string[]a)
	{
		int ctr = 0;
		int []arr = {100,2,34,26,43};         //declare+memory allocation 
		int len = arr.Length;
		while(ctr<len)
		{
		Console.WriteLine(arr[ctr]);
		ctr++;
		}
	}
}