/*
 * Created by SharpDevelop.
 * User: julioc
 * Date: 11/09/2019
 * Time: 03:43 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TALLER
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1, num2, adicion, sustraccion, multiplicacion, divicion, opcion;
			Console.WriteLine("Digite un numero");
			num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite un segundo numero");
			num2 = int.Parse(Console.ReadLine());
			
			Console.WriteLine("las opciones que hay son:");
			Console.WriteLine("1 = adicion");
			Console.WriteLine("2 = sustraccion");
			Console.WriteLine("3 = multiplicacion");
			Console.WriteLine("4 = divicion");
			opcion = int.Parse(Console.ReadLine());
			
			if(opcion==1){
				
				adicion=num1+num2;
				
				Console.WriteLine("la suma entre"+num1+"y"+num2+"es igual a: "+adicion);
				
			}else if(opcion==2){
				sustraccion=num1-num2;
				
				Console.WriteLine("la sustraccion entre"+num1+"y"+num2+"es igual a: "+sustraccion);
			}else if(opcion==3){
				multiplicacion=num1*num2;
				
				Console.WriteLine("la multiplicacion entre"+num1+"y"+num2+"es igual a: "+multiplicacion);
			}else if(opcion==4){
				divicion=num1/num2;
				
				Console.WriteLine("la divicion entre"+num1+"y"+num2+"es igual a: "+divicion);
			}else{
				Console.WriteLine("digite opcion");
			}
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}