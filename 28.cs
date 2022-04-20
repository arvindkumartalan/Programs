using System;
class Demo
{
	public static void Main(string[] a)
	{
		//HOW MANY CHAR CAPITAL AND SMALLER
		int upper=0;
		int lower=0;
		Console.Write("Enter a name : ");
		string str=Console.ReadLine();
		char []arr=str.ToCharArray();
		int ctr=0;
		while(ctr<arr.Length)
		{
			if(arr[ctr]>=65 && arr[ctr]<=90)
				upper++;
			else if(arr[ctr]>=97 && arr[ctr]<=122)
				lower++;
			ctr++;
		}
		Console.WriteLine("Total Upper is : {0} and Toal lower is : {1}" , upper, lower);
	}
}