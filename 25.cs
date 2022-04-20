using System;
class demo
{
	public static void Main(string[]a)
	{
		Console.Write("Please enter your name :");
		string Name = Console.ReadLine();
		Console.Write("Please enter your roll number :");
		int roll = Convert.ToInt32(Console.ReadLine());
		Console.Write("Please enter your physics number :");
		int physics = Convert.ToInt32(Console.ReadLine());
		Console.Write("Please enter your chemestry number :");
		int chem = Convert.ToInt32(Console.ReadLine());
		Console.Write("Please enter your mathmatics number :");
		int math = Convert.ToInt32(Console.ReadLine());
		int total = physics+chem+math;
		Console.WriteLine("total numbers in PCM is :" +total);
		int percentage= total/3;
		Console.WriteLine("Percentage in PCM is :" +percentage);
		if(percentage>=75 && percentage<=100)
			Console.WriteLine(" Passed First Division With Honors");
		else if(percentage>=60 && percentage<=74)
			Console.WriteLine(" Passed First Division");
		else if(percentage>=45 && percentage<=59)
			Console.WriteLine("Passed Second Division");
		else if(percentage>=33 && percentage<=44)
			Console.WriteLine("Passed Third Division");
		else
			Console.WriteLine("FAIL !! Please try again ");

	}
}