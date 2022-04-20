using System;
class Demo
{
	//DEFINE JAGGED ARRAY
	public static void Main(string[]a)
	{
		int [][]arr=new int [3][];
		arr[0]=new int [3];
		arr[1]=new int [2];
		arr[2]=new int [4];
		
		for(int i=0; i<arr.Length; i++)
		{
			for(int j=0; j<arr[i].Length; j++)
			{
				Console.Write( "Please Enter row Array Values : " );
				arr[i][j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		Console.WriteLine();
		
		for(int i=0; i<arr.Length; i++)
		{
			for(int j=0; j<arr[i].Length; j++)
			{
				Console.Write("\t" +arr[i][j]);
			}
			Console.WriteLine();
		}
	}
}