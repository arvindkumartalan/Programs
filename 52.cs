using System;
class Demo
{
	// ARRAY ASSENDING WITHOUT PARAMETER WITH RETURN TYPE
	int[] Assending()
	{
		int []arr={1,5,35,68,90,3,1,2};
		int temp;
		for(int i=0; i<arr.Length; i++)
		{
			for(int j=i+1; j<arr.Length; j++ )
			{
				if(arr[i]>arr[j])
				{
					temp=arr[i];
					arr[i]=arr[j];
					arr[j]=temp;
				}
			}
		}
		return arr;
	}
	public static void Main(string []a)
	{	
		Demo d=new Demo();
		int [] ar = d.Assending();
	
		for(int z=0; z<ar.Length; z++ )
		{
			Console.Write(" " +ar[z]);
		}	
	}
}