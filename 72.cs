using System;
namespace Revision
{
	class DemoPrime
	{
		public void Prime(int num)
		{
			
			for(int i = 1; i<=num; i++)
			{
				int count = 0;
				for(int j= 1; j<=i; j++)
				{
					if(i%j==0 )
					count++;
				}
					if(count==2)
					Console.Write(" " +i);
			}
		}
		public static void Main()
		{
			Console.Write("Please enter any number :");
			int num = int.Parse(Console.ReadLine());
			DemoPrime prime = new DemoPrime();
			prime.Prime(num);
		}
	}
}