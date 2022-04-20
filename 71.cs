using System;
namespace Revision
{
	class DemoPrime
	{
		public string Prime(int num)
		{
			string str ;
			int count = 0;
			for(int i = 1; i<=num; i++)
			{
				if(num%i==0 )
					count++;
			}
			if(count==2)
					str = "Given number is prime number";
				else
					str = "Given number is not prime number";
			return str;
		}
		public static void Main()
		{
			Console.Write("Please enter any number :");
			int num = int.Parse(Console.ReadLine());
			DemoPrime prime = new DemoPrime();
			string str = prime.Prime(num);
			Console.WriteLine(str);
		}
	}
}