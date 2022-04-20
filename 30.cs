using System;
class Demo
{
	public static void Main(string[] a)
	{
		////PRINT DECLARED MULTI DIMENTIONAL 
		int ctr=0;
		int [,]arr={{23,34,45,34},{45,23,67,34},{23,56,78,54}};
		while(ctr<3)
		{
			int ptr=0;
			while(ptr<4)
			{
				Console.Write("\t"  +arr[ctr,ptr]);
				ptr++;
			}
			Console.WriteLine();
			ctr++;
		}
	}
}