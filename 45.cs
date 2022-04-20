using System;
class Demo
{
	// ARRAY ASSENDING WITH PARAMETER WITH RETURN TYPE
	public static int[] Assending(int [] lowTohigh)
	{
		
		int temp;
		for(int i=0; i<lowTohigh.Length; i++)
		{
			for(int j=i+1; j<lowTohigh.Length; j++ )
			{
				if(lowTohigh[i]>lowTohigh[j])
				{
					temp=lowTohigh[i];
					lowTohigh[i]=lowTohigh[j];
					lowTohigh[j]=temp;
				}
			}
		}
		return lowTohigh;
	}
	public static void Main(string []a)
	{
		int []arr={1,5,35,68,90,3,1,2};
		int [] ar = Assending(arr);
	
		for(int z=0; z<ar.Length; z++ )
		{
			Console.WriteLine(ar[z]);
		}	
	}
}