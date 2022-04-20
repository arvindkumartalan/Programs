using System;
class demo
{
	// HOW MANY NUMBERS EVEN AND ODD IN AN ARRAY
	public static void Main(string[] a)
	{
		int ctr = 0;
		int even=0;
		int odd=0;
		Console.Write("How many length you want array : ");
		int Arr = Convert.ToInt32(Console.ReadLine());
		int []arr = new int[Arr];
		int len = arr.Length;
		while(ctr<len)
		{
			Console.Write("Enter the numbers : ");
			arr[ctr] = Convert.ToInt32(Console.ReadLine());
			ctr++;
		}
		for(ctr = 0; ctr<len; ctr++)
		{
			if(arr[ctr]%2==0)
			{
				even++;
			}
			else
			{
				odd++;
			}
		}
		Console.WriteLine("even {0} and odd {1}" , even, odd);
	}
}