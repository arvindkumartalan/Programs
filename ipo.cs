using System;
class WithoutParameterWithoutReturnType
{
	//METHOD WITHOUT PARAMETER WITHOUT RETURN RETURN TYPE
	public static void first(){
		Console.WriteLine("Enter First Number");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Second Number");
		int num2 = Convert.ToInt32(Console.ReadLine());
		int num3 = num1+num2;
		Console.WriteLine(num3);
	}
	public static void Main(string [] a){
		first();
	}
}