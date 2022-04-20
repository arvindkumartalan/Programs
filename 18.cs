using System;
class demo
{
	//FIND SMALLEST NUMBER 
	public static void Main(string [] args)
	{
		int i ;
		int num = 0 ;//5
		int smallest = 0 ;
		int valu ;
		
		
		Console.Write("How many Numbers you want to entered : ");
		num = Convert.ToInt32(Console.ReadLine());
		for(i=1; i<=num; i++)
		{
			Console.Write("Enter the numbers : ");
			valu = Convert.ToInt32(Console.ReadLine());
			if(i==1)
				smallest = valu;//5
			else if(valu<smallest)//7
				smallest = valu;
				
		}
			Console.WriteLine("Smallest Number is :" +smallest);
		
	}
}