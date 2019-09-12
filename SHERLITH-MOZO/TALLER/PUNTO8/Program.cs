/*
 * Created by SharpDevelop.
 * User: julioc
 * Date: 11/09/2019
 * Time: 05:41 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PUNTO8
{
	class Program
	{
		public static void Main(string[] args)
		{
			double precio, descuento, total;
			Console.WriteLine("digite el precio");
			precio = int.Parse(Console.ReadLine());
			
			if(precio>=200){
				
				descuento = precio*0.15;
				total=precio-descuento;
				Console.WriteLine("su total a pagar es: $"+total+"--tuvo un descuento de 15% es decir: "+descuento);
			}else if(precio>100 && precio<200){
				
				descuento = precio*0.12;
				total=precio-descuento;
				Console.WriteLine("su total a pagar es: $"+total+"--tuvo un descuento de 12% es decir: "+descuento);
			}else if(precio<100){
				
				descuento = precio*0.10;
				total=precio-descuento;
				Console.WriteLine("su total a pagar es: $"+total+"---tuvo un descuento de 10% es decir: "+descuento);
			}else{
				
				Console.WriteLine("digite el precio");
			}
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}