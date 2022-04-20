using System;
class Demo
{
	//TO FIND A GREATEST NUMBER IN A ARRAY
	public static int Max(int []a)
	{
		int h=a[0];
		for(int i=0; i<a.Length; i++)
		{
			if(a[i]>h)
				h=a[i];
		}
		return h;
	}
	public static void Main(string []a)
	{
		int []arr={1,5,35,68,90,3,1,2};
		int high=Max(arr);
		Console.WriteLine("The highest value in given array is : "+high);
	}
}