using System;
class demo
{
		//FIND GREATEST NUMBER 
	public static void Main(string [] args)
	{
		int i ;
		int num = 0 ;//5
		int greater = 0 ;
		int valu ;
		
		
		Console.Write("How many Numbers you want to entered : ");
		num = Convert.ToInt32(Console.ReadLine());
		for(i=1; i<=num; i++)
		{
			Console.Write("Enter the numbers : ");
			valu = Convert.ToInt32(Console.ReadLine());
			if(i==1)
				greater = valu;//5
			else if(valu>greater)//7
				greater = valu;
				
		}
			Console.WriteLine("Greater Number is :" +greater);
		
	}
}