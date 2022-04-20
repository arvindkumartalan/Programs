using System;
class Demo
{
	public static void Main(string [] args)
	{
		while(true)
		{
			Console.Write("Please enter a string : ");
			string str = Console.ReadLine();
			char []arr = str.ToCharArray();
			for( int i=0; i<arr.Length; i++)
			{
			if(arr[i]=='a' || arr[i]=='e' || arr[i]=='i' || arr[i]=='o' || arr[i]=='u' || arr[i]=='A' || arr[i]=='E' || arr[i]=='I' || arr[i]=='O' || arr[i]=='U')
			
				Console.WriteLine("Vowel Hai");
			
				else
				Console.WriteLine("Constant Hai");	
			
			}
			Console.Write("Do You Want to Cotinue : Yes/No ");
			string confirm = Console.ReadLine().ToLower();
			if(confirm == "yes")
			
				continue;
			
			else
				break;
		}
	}
}