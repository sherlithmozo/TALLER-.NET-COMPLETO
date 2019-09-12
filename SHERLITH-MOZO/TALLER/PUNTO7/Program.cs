/*
 * Created by SharpDevelop.
 * User: julioc
 * Date: 11/09/2019
 * Time: 05:35 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PUNTO7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1, num2, num3;
			Console.WriteLine("digite 3 numeros");
			num1 = int.Parse(Console.ReadLine());
			num2 = int.Parse(Console.ReadLine());
			num3 = int.Parse(Console.ReadLine());
			
			if(num1>num2 && num1>num3){
				Console.WriteLine("el numero mayor es: "+num1);
			}else if(num2>num1 && num2>num3){
				Console.WriteLine("el numero mayor es: "+num2);
			}else if(num3>num1 && num3>num2){
				Console.WriteLine("el numero mayor es: "+num3);
			}else{
				Console.WriteLine("digite 3 numeros");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}