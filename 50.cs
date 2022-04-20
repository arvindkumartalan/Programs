using System;
class Demo
{
	//DEFINE CHAR JAGGED ARRAY
	public static void Main(string[]a)
	{
		char [][]arr=new char [3][];
		arr[0]=new char [3];
		arr[1]=new char [2];
		arr[2]=new char [4];
		
		for(int i=0; i<arr.Length; i++)
		{
			for(int j=0; j<arr[i].Length; j++)
			{
				Console.Write( "Please Enter row Array Values : " );
				arr[i][j]=char.Parse(Console.ReadLine());
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