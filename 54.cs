using System;
class Demo
{
	//CALL NON STATIC METHOD INTO STATIC METHOD WITH REFERENCE VARIABLE OR OBJECT
	public static void Main(string[]a)
	{
		Demo sub = new Demo();
		sub.Subtract();
		sub.Add();
		Console.WriteLine("Addition, Subtract and Multi" );
		
	}
	void Add()
	{
		Console.WriteLine("Addition is : " );
		
	}
	void Subtract()
	{
		int i = 50;
		int j = 80;
		int k = i-j;
		Console.WriteLine("Subtract is : " +k);
		multi();
		
	}
	static void multi()
	{
		int i = 50;
		int j = 80;
		int k = i*j;
		Console.WriteLine("Multi is : " +k);
		Demo sub = new Demo();
		sub.Add();
		
	}
	
}