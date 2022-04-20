using System;
class Demo
{
	// TO FIND A NUMBER IN ARRAY WHICH IS PRESENT OR NOT
	public static void Main(string []a)
	{
		int []arr={1,5,35,68,90,3,1,2};
		Console.Write("Enter a no. find in Array : ");
		int find = int.Parse(Console.ReadLine());
		bool x=false;
		for(int i=0; i<arr.Length; i++)
		{
			if(arr[i]==find)
			{
				x=true;
				break;
			}
		}
		if(x==false)
			Console.WriteLine("Number not found in given array");
		else
			Console.WriteLine("Number found in given array");
	}
}