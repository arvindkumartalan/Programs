using System;
class Great
{
	public static void Number()
	{
		//TO FIND GREATER NUMBER WITHOUT PARAMETR WITHOUT RETURN RETURN TYPE
		string result;
		Console.Write("Enter First Number");
		short num1 = Convert.ToInt16(Console.ReadLine());
		Console.Write("Enter Second Number");
		short num2 = Convert.ToInt16(Console.ReadLine());
		if(num1 > num2)
			result = "num1 is greater";
		else if (num2 > num1)
			result = "num2 is greater";
		else
			result = "Both are Equal";
		Console.WriteLine(result);
	}
	public static void Main(string [] a)
	{
		Number();
	}
}