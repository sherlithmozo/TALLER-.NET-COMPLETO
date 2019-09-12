/*
 * Created by SharpDevelop.
 * User: julioc
 * Date: 11/09/2019
 * Time: 05:07 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PUNTO4
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre;
			double unidad, importe;
			
			Console.WriteLine("digite su nombre");
			nombre = Console.ReadLine();
			Console.WriteLine("digite la unidad consumidas");
			unidad = int.Parse(Console.ReadLine());
			
			if(unidad<=199){
				importe = unidad/1.2;
				Console.WriteLine("el total a pagar es: " + importe);
			}else if(unidad>199 && unidad<=399){
				importe = unidad/1.5;
				Console.WriteLine("el total a pagar es: " + importe);
			}else if(unidad>399 && unidad<=599){
				importe = unidad/1.8;
				Console.WriteLine("el total a pagar es: " + importe);
			}else if(unidad>600){
				importe = unidad/2;
				Console.WriteLine("el total a pagar es: " + importe);
			}else{
				Console.WriteLine("digite unidad");
			}
			
			
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}