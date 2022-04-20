using System;
class Demo
{
	// TO FIND A STRING IN ARRAY WHICH IS PRESENT OR NOT
	public static void Main(string []a)
	{
		string[]arr={"arvind", "amit", "rakesh", "seema", "sheha"};
		Console.Write("Enter a name find in Array : ");
		string find = Console.ReadLine();
		bool x=false;
		for(int i=0; i<arr.Length; i++)
		{
			if(arr[i]==find)
			{
				x=true;
				break;
			}
		}
		if(x==false)
			Console.WriteLine("Name not found in given array");
		else
			Console.WriteLine("name found in given array");
	}
}