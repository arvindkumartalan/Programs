using System;
class WithoutParameterWithReturnType
{
	//METHOD WITHOUT PARAMETER WITH RETURN RETURN TYPE
	public static int fourth(){
		int num1 = 738;
		int num2 = 827;
		int num3 = num1+num2;
		return num3;
	}
	public static void Main(string [] a){
		int result = fourth();
		Console.WriteLine("Result Is :" +result);
	}
}