using System;
class Demo
{
	public static void Main(string[] a)
	{
		//TO ADDITION OD 2D ARRAY CROSS 
		Console.Write("Please enter rows : ");
		int row=Convert.ToInt32(Console.ReadLine());
		Console.Write("Please enter rows : ");
		int col=Convert.ToInt32(Console.ReadLine());
		int [,]arr=new int[row,col];
		int ctr=0;
		while(ctr<row)
		{
			int ptr=0;
			while(ptr<col)
			{
				Console.Write("Enter Number :");
				arr[ctr,ptr]=Convert.ToInt32(Console.ReadLine());
				ptr++;
			}
			ctr++;
		}
		int y=0;
		while(y<row)
		{
			int ptr=0;
			while(ptr<col)
			{
				Console.Write("\t"+arr[y,ptr]);
				ptr++;
			}
			Console.WriteLine();
			y++;
		}
		int sum = 0;
		for(int x=0; x<row; x++)
		{
			
			for(int z =0; z<col; z++)
			{
				if(x==z)
				sum = arr[x,z]+sum;				
			}	
		}
		Console.WriteLine("Cross Addition is :" +sum);
	}
}