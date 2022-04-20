using System;
class Demo
{
	//DEFINE STRING JAGGED ARRAY
	public static void Main(string[]a)
	{
		string [][]arr=new string [3][];
		arr[0]=new string [3];
		arr[1]=new string [2];
		arr[2]=new string [4];
		
		for(int i=0; i<arr.Length; i++)
		{
			for(int j=0; j<arr[i].Length; j++)
			{
				Console.Write( "Please Enter row Array Values : " );
				arr[i][j]=Console.ReadLine();
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