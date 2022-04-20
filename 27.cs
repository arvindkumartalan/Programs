using System;
class demo
{
	public static void Main(string[]a)
	{
		int r=0;
		int ctr=1;
		int ptr;
		while(ctr<=5)
		{
			int num=0;
			ptr=1;
			while(ptr<=5)
			{
				Console.Write(" " +ptr);
				num=num+ptr;
				ptr++;
			
			if(ptr==1)
			{
			Console.WriteLine(" Columns sum is = "+num);
			}}
			Console.WriteLine();
			
			ctr++;
			r=ctr;
			
		}
		r--;
		Console.WriteLine(" Row sum is = "+r);
		
	}
}