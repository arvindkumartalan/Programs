using System;
class Demo
{
	//input and array, find even and odd and count no. of even and odd
	public static void Main(string[]a)
	{
		Console.Write("Enter array length : ");
		int len=Convert.ToInt32(Console.ReadLine());
		int []arr=new int[len];
		int ctr=0;
		while(ctr<len)
		{
			Console.Write("Enter numbers : ");
			arr[ctr]=Convert.ToInt32(Console.ReadLine());
			ctr++;
		}
		int y=0;
		while(y<len)
		{
			Console.Write("\t" +arr[y]);
			y++;
		}
		Console.WriteLine();
		int e=0;
		int o=0;
		int[]even=new int [e];
		int[]odd=new int [o];
		int x=0;
		while(x<len)
		{
			if(arr[x]%2==0)
				Console.WriteLine("Number is Even : " +arr[x]);
			else
			Console.WriteLine("Number is odd : "+arr[x]);	
			x++;		
		}
		int z=0;
		while(z<len)
		{
			if(arr[z]%2==0)
				e++;
			else
			o++;
			z++;
		}
		Console.WriteLine("even no is : " +e);
		Console.WriteLine("odd no is : " +o);
	}
}