using System;
class Demo
{
	public static void Main(string[] a)
	{
		//PRINT MULTI DIMENTIONAL ARRAY WITH STRING
		Console.Write("Please enter rows : ");
		int row=Convert.ToInt32(Console.ReadLine());
		Console.Write("Please enter rows : ");
		int col=Convert.ToInt32(Console.ReadLine());
		string [,]arr=new string[row,col];
		int ctr=0;
		while(ctr<row)
		{
			int ptr=0;
			while(ptr<col)
			{
				Console.Write("Enter STRING :");
				arr[ctr,ptr]=Console.ReadLine();
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
		
	}
}