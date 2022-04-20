using System;
class Demo
{
	// ARRAY ASSENDING WITHOUT PARAMETER WITHOUT RETURN TYPE
	public static void Assending()
	{
		int []arr={1,5,386,68,90,3,1456,2};
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
		for(int z=0; z<arr.Length; z++ )
		{
			Console.WriteLine(arr[z]);
		}
	}
	public static void Main(string []a)
	{
		
		Assending();
		
		
		
	}
}