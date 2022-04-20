using System;
class Demo
{
	//DEFINE JAGGED ARRAY
	public static void Main(string[]a)
	{
		int [][]arr;
		arr=new int [3][];
		arr[0]=new int [3];
		arr[1]=new int [2];
		arr[2]=new int [4];
		
		arr[0][0]=101;
		arr[0][1]=70;
		arr[0][2]=60;
		
		arr[1][0]=80;
		arr[1][1]=90;
		
		arr[2][0]=40;
		arr[2][1]=30;
		arr[2][2]=20;
		arr[2][3]=10;
		
		Console.WriteLine(arr[0][0]);
		Console.WriteLine(arr[0][1]);
		Console.WriteLine(arr[0][2]);
		
		Console.WriteLine(arr[1][0]);
		Console.WriteLine(arr[1][1]);
		
		Console.WriteLine(arr[2][0]);
		Console.WriteLine(arr[2][1]);
		Console.WriteLine(arr[2][2]);
		Console.WriteLine(arr[2][3]);
	}
}